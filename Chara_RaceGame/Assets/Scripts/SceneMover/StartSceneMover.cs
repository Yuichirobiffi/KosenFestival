using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSceneMover : MonoBehaviour {
    //Scene移動までの待機時間
    public float timeCount;

    //Playerがスタートしたかしてないかを示すやつ
    public static int p1;
    public static int p2;
    public static int p3;
    public static int p4;

    //ready?とかok!のPlayerごとのテキスト
    private Text pOne;
    private Text pTwo;
    private Text pThree;
    private Text pFour;

    void Start(){
        timeCount = 1.5f;
        p1 = 0;
        p2 = 0;
        p3 = 0;
        p4 = 0;
    }

    void Update () {
        //Player1 Start可能
        if (Input.GetKeyDown(KeyCode.Q)){
            p1 = 1;
        }
        //Player2 Start可能
        if (Input.GetKeyDown(KeyCode.W)){
            p2 = 1;
        }
        //Player3 Start可能
        if (Input.GetKeyDown(KeyCode.E)){
            p3 = 1;
        }
        //Player4 Start可能
        if (Input.GetKeyDown(KeyCode.R)){
            p4 = 1;
        }

        //全員Start可能になったら
        if(p1 == 1 && p2 == 1 && p3 == 1 && p4 == 1){
            //待機時間
            if (timeCount >= 0){
                timeCount -= Time.deltaTime;
            }
            //待機時間終わったらScene移動
            if (timeCount <= 0){
                SceneManager.LoadScene("Game");
            }
        }
    }
}
