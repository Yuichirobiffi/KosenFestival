using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneMover : MonoBehaviour {
    //Scene移動までの待機時間
    public float timeCount;

    //箱の数を格納
    public int num;

    //Player1～Player4の箱積む数を格納する
    public static int p1;
    public static int p2;
    public static int p3;
    public static int p4;

    void Start(){
        timeCount = 1.5f;
        p1 = -1;
        p2 = -1;
        p3 = -1;
        p4 = -1;
        num = 3;
    }


    void Update () {
        //Player1がGoalしたら
        if (UnityChanControlScriptWithRgidBody.is_Goaling_Not == 0 && p1 == -1){
            p1 = num;
            num--;
        }
        //Player2がGoalしたら
        if (UnityChanControlScriptWithRgidBody2.is_Goaling_Not == 0 && p2 == -1){
            p2 = num;
            num--;
        }
        //Player3がGoalしたら
        if (UnityChanControlScriptWithRgidBody3.is_Goaling_Not == 0 && p3 == -1){
            p3 = num;
            num--;
        }
        //Player4がGoalしたら
        if (UnityChanControlScriptWithRgidBody4.is_Goaling_Not == 0 && p4 == -1){
            p4 = num;
            num--;
        }

        //全員Goalしたら
        if (UnityChanControlScriptWithRgidBody.is_Goaling_Not == 0 && UnityChanControlScriptWithRgidBody2.is_Goaling_Not == 0 &&
        UnityChanControlScriptWithRgidBody3.is_Goaling_Not == 0 && UnityChanControlScriptWithRgidBody4.is_Goaling_Not == 0){
            //待機時間
            if (timeCount >= 0){
                timeCount -= Time.deltaTime;
            }
            //待機時間終わったらScene移動
            if (timeCount <= 0){
                SceneManager.LoadScene("End");
            }
        }

    }
}
