//
// Mecanimのアニメーションデータが、原点で移動しない場合の Rigidbody付きコントローラ
// サンプル
// 2014/03/13 N.Kobyasahi
//
using UnityEngine;
using System.Collections;

// 必要なコンポーネントの列記
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(Rigidbody))]

public class UnityChanControlScriptWithRgidBody4 : MonoBehaviour{

    //よくわからん
    public float lookSmoother = 3.0f;
    public bool useCurves = true;
    public float useCurvesHeight = 0.5f;
    // キャラクターコントローラ（カプセルコライダ）の参照
    private CapsuleCollider col;
    private Rigidbody rb;
    // キャラクターコントローラ（カプセルコライダ）の移動量
    private Vector3 velocity;
    // CapsuleColliderで設定されているコライダのHeiht、Centerの初期値を収める変数
    private float orgColHight;
    private Vector3 orgVectColCenter;
    // キャラにアタッチされるアニメーターへの参照
    private Animator anim;
    //

    //アニメーションのスピード
    public float animSpeed = 1.5f;

    // 前進速度
    public float forwardSpeed = 7.0f;

    // ゴール してる：0 してない:1
    public static float is_Goaling_Not = 1.0f;

    //タイマーの秒数
    public float timeCount = 3.0f;

    //定数
    private int[] SIDE = { -2, -1, 0, 1, 2 }; //横の座標を格納
    private float[] TORELANCE = { -1.5f, -0.5f, 0.5f, 1.5f }; //許容範囲 
    private const float ADD_SPEED = 0.3f; //スピード増減
    private const float BACK_POWER = 25.0f; //後ろに吹っ飛ぶ力

    // 初期化
    void Start(){
        //よくわからん
        // Animatorコンポーネントを取得する
        anim = GetComponent<Animator>();
        // CapsuleColliderコンポーネントを取得する（カプセル型コリジョン）
        col = GetComponent<CapsuleCollider>();
        rb = GetComponent<Rigidbody>();
        // CapsuleColliderコンポーネントのHeight、Centerの初期値を保存する
        orgColHight = col.height;
        orgVectColCenter = col.center;
        //

        //位置初期化
        transform.position = new Vector3(-10.0f, 0.25f, 0.0f);
        is_Goaling_Not = 1.0f;
        forwardSpeed = 7.0f;
    }

    void Update(){
        if (timeCount >= 0) {
            timeCount -= Time.deltaTime;
            //Debug.Log(timeCount);
        }

        if (timeCount <= 0){
            //よくわからん
            // Animatorのモーション再生速度に animSpeedを設定する
            anim.speed = animSpeed;
            //ジャンプ中に重力を切るので、それ以外は重力の影響を受けるようにする
            rb.useGravity = true;
            //

            //前進アニメ常時設定
            anim.SetFloat("Speed", 1);

            //現在位置取得
            Transform myTransForm = this.transform;
            Vector3 pos = myTransForm.position;

            //位置ズレ防止用
            if (pos.z < TORELANCE[0]){
                pos.z = SIDE[0];
            }
            else if (pos.z < TORELANCE[1]){
                pos.z = SIDE[1];
            }
            else if (pos.z < TORELANCE[2]){
                pos.z = SIDE[2];
            }
            else if (pos.z < TORELANCE[3]){
                pos.z = SIDE[3];
            }
            else{
                pos.z = SIDE[4];
            }

            //前移動
            velocity = new Vector3(0, 0, 1);
            // キャラクターのローカル空間での方向に変換
            velocity = transform.TransformDirection(velocity);
            // 移動速度を掛ける(Goalしたらis_Goaling_Notが0になるから動かなくなる)
            velocity *= forwardSpeed * is_Goaling_Not;
            //キャラクター前進
            transform.localPosition += velocity * Time.deltaTime;

            //右移動
            if (Input.GetButtonDown("Right4")){
                //移動制限
                if (pos.z <= TORELANCE[3]){
                    pos.z += 1.0f * is_Goaling_Not;
                    myTransForm.position = pos;
                }
            }

            //左移動
            if (Input.GetButtonDown("Left4")){
                //移動制限
                if (pos.z >= TORELANCE[0]){
                    pos.z -= 1.0f * is_Goaling_Not;
                    myTransForm.position = pos;
                }
            }
        }
    }
    /*
    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width -260, 10 ,250 ,150), "Interaction");
        GUI.Label(new Rect(Screen.width -245,30,250,30),"Up/Down Arrow : Go Forwald/Go Back");
        GUI.Label(new Rect(Screen.width -245,50,250,30),"Left/Right Arrow : Turn Left/Turn Right");
        GUI.Label(new Rect(Screen.width -245,70,250,30),"Hit Space key while Running : Jump");
        GUI.Label(new Rect(Screen.width -245,90,250,30),"Hit Spase key while Stopping : Rest");
        GUI.Label(new Rect(Screen.width -245,110,250,30),"Left Control : Front Camera");
        GUI.Label(new Rect(Screen.width -245,130,250,30),"Alt : LookAt Camera");
    }
    */

    //よくわからん
    void resetCollider(){
        col.height = orgColHight;
        col.center = orgVectColCenter;
    }
    //

    //Goal判定
    private void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "goal"){
            //ゴールアニメ開始
            anim.SetBool("Goal", true);
            //前進アニメ停止
            anim.SetFloat("Speed", 0);
            //これで、横、前進移動停止
            is_Goaling_Not = 0;
        }

        if (other.gameObject.tag == "wall"){
            //後跳んでけ
            Rigidbody RB = this.GetComponent<Rigidbody>();
            Vector3 force = new Vector3(BACK_POWER, 0, 0);
            RB.AddForce(force, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "speedup"){
            //前進速度増加
            forwardSpeed += ADD_SPEED;
            //Debug.Log(forwardSpeed);
        }

        if (other.gameObject.tag == "speeddown"){
            //前進速度低下
            forwardSpeed -= ADD_SPEED;
            //Debug.Log(forwardSpeed);
        }
    }
}