using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Effect : MonoBehaviour {

    //for文用
    private int i;
    //何位かを格納するやつ
    private int num;
    //並べる箱
    public GameObject BoxPrefab;

    //定数
    public const float P1_X = -1.5f;//Player1のX座標
    public const float P2_X = -0.5f;//Player2のX座標
    public const float P3_X =  0.5f;//Player3のX座標
    public const float P4_X =  1.5f;//Player4のX座標
    public const float START_Y = -3.0f;//Y座標の開始位置
    public const float BOX_HALF_HIGH = 0.5f;//箱の高さの半分

    void Start () {
        //Player1の箱並べる
        num = GameSceneMover.p1;
        for (i = 0; i <= num; i++){
            GameObject Stand = Instantiate(BoxPrefab) as GameObject;
            Stand.transform.position = new Vector3(P1_X, START_Y + BOX_HALF_HIGH * i, 0.0f);
        }
        //Player2の箱並べる
        num = GameSceneMover.p2;
        for (i = 0; i <= num; i++){
            GameObject Stand = Instantiate(BoxPrefab) as GameObject;
            Stand.transform.position = new Vector3(P2_X, START_Y + BOX_HALF_HIGH * i, 0.0f);
        }
        //Player3の箱並べる
        num = GameSceneMover.p3;
        for (i = 0; i <= num; i++){
            GameObject Stand = Instantiate(BoxPrefab) as GameObject;
            Stand.transform.position = new Vector3(P3_X, START_Y + BOX_HALF_HIGH * i, 0.0f);
        }
        //Player4の箱並べる
        num = GameSceneMover.p4;
        for (i = 0; i <= num; i++){
            GameObject Stand = Instantiate(BoxPrefab) as GameObject;
            Stand.transform.position = new Vector3(P4_X, START_Y + BOX_HALF_HIGH * i, 0.0f);
        }
    }
}
