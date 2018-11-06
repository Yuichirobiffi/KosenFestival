using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Unity : MonoBehaviour {
    
    void Start () {
        //Player1が1位の時
	    if(GameSceneMover.p1 == 3){
            transform.position = new Vector3(-1.5f, -1.0f, 0.0f);
        }
        //Player1が2位の時
        else if (GameSceneMover.p1 == 2){
            transform.position = new Vector3(-1.5f, -1.5f, 0.0f);
        }
        //Player1が3位の時
        else if (GameSceneMover.p1 == 1){
            transform.position = new Vector3(-1.5f, -2.0f, 0.0f);
        }
        //Player1が4位の時
        else if (GameSceneMover.p1 == 0){
            transform.position = new Vector3(-1.5f, -2.5f, 0.0f);
        }
    }
}
