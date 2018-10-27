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

public class UnityChanControlScriptWithRgidBody : MonoBehaviour{

    //よくわからん
    public float animSpeed = 2.0f;
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
    // base layerで使われる、アニメーターの現在の状態の参照
    private AnimatorStateInfo currentBaseState;
    // メインカメラへの参照
    private GameObject cameraObject;

    // 前進速度
    public float forwardSpeed = 7.0f;

    // ゴール してる：0 してない:1
    public float is_Goaling_Not = 1.0f;
    
    // アニメーター各ステートへの参照
    static int idleState = Animator.StringToHash("Base Layer.Idle");
    static int locoState = Animator.StringToHash("Base Layer.Locomotion");
    static int jumpState = Animator.StringToHash("Base Layer.Jump");
    static int restState = Animator.StringToHash("Base Layer.Rest");

    // 初期化
    void Start(){
        // Animatorコンポーネントを取得する
        anim = GetComponent<Animator>();
        // CapsuleColliderコンポーネントを取得する（カプセル型コリジョン）
        col = GetComponent<CapsuleCollider>();
        rb = GetComponent<Rigidbody>();
        //メインカメラを取得する
        cameraObject = GameObject.FindWithTag("MainCamera");
        // CapsuleColliderコンポーネントのHeight、Centerの初期値を保存する
        orgColHight = col.height;
        orgVectColCenter = col.center;
        //位置初期化
        transform.position = new Vector3(1.0f, 0.5f, 10.0f);
    }


    // 以下、メイン処理.リジッドボディと絡めるので、FixedUpdate内で処理を行う.
    void FixedUpdate(){
        //Jumpアニメ停止
        anim.SetBool("Jump", false);

        //現在位置取得
        Transform myTransForm = this.transform;

        //前進アニメ常時設定
        anim.SetFloat("Speed", 1);

        //よくわからん
        // Animatorのモーション再生速度に animSpeedを設定する
        anim.speed = animSpeed;
        // 参照用のステート変数にBase Layer (0)の現在のステートを設定する
        currentBaseState = anim.GetCurrentAnimatorStateInfo(0);
        //ジャンプ中に重力を切るので、それ以外は重力の影響を受けるようにする
        rb.useGravity = true;


        //前移動
        velocity = new Vector3(0, 0, 1);
        // キャラクターのローカル空間での方向に変換
        velocity = transform.TransformDirection(velocity);
        // 移動速度を掛ける
        velocity *= forwardSpeed * is_Goaling_Not;
        //キャラクター前進
        transform.localPosition += velocity * Time.fixedDeltaTime;


        //右移動
        if (Input.GetKeyDown(KeyCode.D)){
            //Jumpアニメ開始
            anim.SetBool("Jump", true);
            //現在位置取得
            Vector3 pos = myTransForm.position;
            pos.x += 1.0f * is_Goaling_Not;
            myTransForm.position = pos;
        }
        //左移動
        else if (Input.GetKeyDown(KeyCode.A)){
            //Jumpアニメ開始
            anim.SetBool("Jump", true);
            //現在位置取得
            Vector3 pos = myTransForm.position;
            pos.x -= 1.0f * is_Goaling_Not;
            myTransForm.position = pos;
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

    // キャラクターのコライダーサイズのリセット関数
    void resetCollider(){
        // コンポーネントのHeight、Centerの初期値を戻す
        col.height = orgColHight;
        col.center = orgVectColCenter;
    }

    //Goal判定
    private void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "goal"){
            //180度回転
            transform.Rotate(0,180, 0);
            //ゴールアニメ開始
            anim.SetBool("Goal", true);
            //前進アニメ停止
            anim.SetFloat("Speed", 0);
            //これで、横、前進移動停止
            is_Goaling_Not = 0;
            
        }
    }

}