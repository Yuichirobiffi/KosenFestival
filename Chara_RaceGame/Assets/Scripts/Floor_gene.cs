using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_gene : MonoBehaviour {

    public GameObject FloorPrefabX;
    public GameObject FloorPrefabZ;
    public GameObject GoalPrefabX;
    public GameObject GoalPrefabZ;

    private float i, j;

    //定数
    private const float LOAD_LONG = 210.0f; //長さ
    private const float LOAD_START = 10.0f; //開始位置

    void Start () {

        for (i = LOAD_START; i <= LOAD_LONG; i++){
            if (i == LOAD_LONG){
                GameObject Goal = Instantiate(GoalPrefabX) as GameObject;
                Goal.transform.position = new Vector3(0.0f, 0.0f, 0.0f + i);
            } else{
                GameObject Floor = Instantiate(FloorPrefabX) as GameObject;
                Floor.transform.position = new Vector3(0.0f, 0.0f, 0.0f + i);
            }
        }

        //90度////////////////////////////////////////////////////////////////////
        for (i = LOAD_START; i <= LOAD_LONG; i++){
            if (i == LOAD_LONG){
                GameObject Goal = Instantiate(GoalPrefabZ) as GameObject;
                Goal.transform.position = new Vector3(0.0f + i, 0.0f, 0.0f);
            } else{
                GameObject Floor = Instantiate(FloorPrefabZ) as GameObject;
                Floor.transform.position = new Vector3(0.0f + i, 0.0f, 0.0f);
            }
        }

        //180度////////////////////////////////////////////////////////////////////
        for (i = -LOAD_START; i >= -LOAD_LONG; i--){
            if (i == -LOAD_LONG){
                GameObject Goal = Instantiate(GoalPrefabX) as GameObject;
                Goal.transform.position = new Vector3(0.0f, 0.0f, 0.0f + i);
            } else{
                GameObject Floor = Instantiate(FloorPrefabX) as GameObject;
                Floor.transform.position = new Vector3(0.0f, 0.0f, 0.0f + i);
            }
        }

        //270度////////////////////////////////////////////////////////////////////
        for (i = -LOAD_START; i >= -LOAD_LONG; i--){
            if (i == -LOAD_LONG){
                GameObject Goal = Instantiate(GoalPrefabZ) as GameObject;
                Goal.transform.position = new Vector3(0.0f + i, 0.0f, 0.0f);
            }else{
                GameObject Floor = Instantiate(FloorPrefabZ) as GameObject;
                Floor.transform.position = new Vector3(0.0f + i, 0.0f, 0.0f);
            }
        }
    }
}
