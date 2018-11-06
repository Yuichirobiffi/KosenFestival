using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Unity4 : MonoBehaviour {
    
    void Start () {
        //Player4が1位の時
        if (GameSceneMover.p4 == 3){
            transform.position = new Vector3(1.5f, -1.0f, 0.0f);
        }
        //Player4が2位の時
        else if (GameSceneMover.p4 == 2){
            transform.position = new Vector3(1.5f, -1.5f, 0.0f);
        }
        //Player4が3位の時
        else if (GameSceneMover.p4 == 1){
            transform.position = new Vector3(1.5f, -2.0f, 0.0f);
        }
        //Player4が4位の時
        else if (GameSceneMover.p4 == 0){
            transform.position = new Vector3(1.5f, -2.5f, 0.0f);
        }
    }
}
