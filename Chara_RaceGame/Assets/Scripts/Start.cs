using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour {

    int p1 = 0;
    int p2 = 0;
    int p3 = 0;
    int p4 = 0;

    void Update () {
        string scene_name = SceneManager.GetActiveScene().name;
        //Debug.Log(scene_name);

        if (Input.GetKeyDown(KeyCode.Q)){
            p1 = 1;
        }
        if (Input.GetKeyDown(KeyCode.W)){
            p2 = 1;
        }
        if (Input.GetKeyDown(KeyCode.E)){
            p3 = 1;
        }
        if (Input.GetKeyDown(KeyCode.R)){
            p4 = 1;
        }

        if(p1 == 1 && p2 == 1 && p3 == 1 && p4 == 1){
            SceneManager.LoadScene("Game");
        }
    }
}
