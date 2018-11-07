using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor_gene : MonoBehaviour {

    //for文用の
    private float i, j;

    //床とゴールのプレハブ
    public GameObject FloorPrefabX;
    public GameObject FloorPrefabZ;
    public GameObject GoalPrefabX;
    public GameObject GoalPrefabZ;
    
    //定数
    private const float LOAD_LONG = 210.0f; //道の長さ
    private const float LOAD_START = 10.0f; //道の開始位置

    void Start () {
        //Player1の道作成
        for (i = LOAD_START; i <= LOAD_LONG; i++){
            if (i == LOAD_LONG){ //Goal設置
                GameObject Goal = Instantiate(GoalPrefabX) as GameObject;
                Goal.transform.position = new Vector3(0.0f, 0.0f, 0.0f + i);
            } else{
                GameObject Floor = Instantiate(FloorPrefabX) as GameObject;
                Floor.transform.position = new Vector3(0.0f, 0.0f, 0.0f + i);
            }
        }
        //Player2の道作成
        for (i = LOAD_START; i <= LOAD_LONG; i++){
            if (i == LOAD_LONG){ //Goal設置
                GameObject Goal = Instantiate(GoalPrefabZ) as GameObject;
                Goal.transform.position = new Vector3(0.0f + i, 0.0f, 0.0f);
            } else{
                GameObject Floor = Instantiate(FloorPrefabZ) as GameObject;
                Floor.transform.position = new Vector3(0.0f + i, 0.0f, 0.0f);
            }
        }
        //Player3の道作成
        for (i = -LOAD_START; i >= -LOAD_LONG; i--){
            if (i == -LOAD_LONG){ //Goal設置
                GameObject Goal = Instantiate(GoalPrefabX) as GameObject;
                Goal.transform.position = new Vector3(0.0f, 0.0f, 0.0f + i);
            } else{
                GameObject Floor = Instantiate(FloorPrefabX) as GameObject;
                Floor.transform.position = new Vector3(0.0f, 0.0f, 0.0f + i);
            }
        }
        //Player4の道作成
        for (i = -LOAD_START; i >= -LOAD_LONG; i--){
            if (i == -LOAD_LONG){ //Goal設置
                GameObject Goal = Instantiate(GoalPrefabZ) as GameObject;
                Goal.transform.position = new Vector3(0.0f + i, 0.0f, 0.0f);
            } else{
                GameObject Floor = Instantiate(FloorPrefabZ) as GameObject;
                Floor.transform.position = new Vector3(0.0f + i, 0.0f, 0.0f);
            }
        }
    }
}
