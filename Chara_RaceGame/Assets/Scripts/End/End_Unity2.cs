using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Unity2 : MonoBehaviour {
    
    void Start () {
        //Player2が1位の時
        if (GameSceneMover.p2 == 3){
            transform.position = new Vector3(-0.5f, -1.0f, 0.0f);
        }
        //Player2が2位の時
        else if (GameSceneMover.p2 == 2){
            transform.position = new Vector3(-0.5f, -1.5f, 0.0f);
        }
        //Player2が3位の時
        else if (GameSceneMover.p2 == 1){
            transform.position = new Vector3(-0.5f, -2.0f, 0.0f);
        }
        //Player2が4位の時
        else if (GameSceneMover.p2 == 0){
            transform.position = new Vector3(-0.5f, -2.5f, 0.0f);
        }
    }
}
