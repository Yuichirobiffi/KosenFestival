using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Unity3 : MonoBehaviour {
    
    void Start () {
        //Player3が1位の時
        if (GameSceneMover.p3 == 3){
            transform.position = new Vector3(0.5f, -1.0f, 0.0f);
        }
        //Player3が2位の時
        else if (GameSceneMover.p3 == 2){
            transform.position = new Vector3(0.5f, -1.5f, 0.0f);
        }
        //Player3が3位の時
        else if (GameSceneMover.p3 == 1){
            transform.position = new Vector3(0.5f, -2.0f, 0.0f);
        }
        //Player3が4位の時
        else if (GameSceneMover.p3 == 0){
            transform.position = new Vector3(0.5f, -2.5f, 0.0f);
        }
    }
}
