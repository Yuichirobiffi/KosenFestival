using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneMover : MonoBehaviour {
	void Update () {
        //Enter押されたら(運営側のノートPC)
        if (Input.GetKeyDown(KeyCode.Return)){
            //Scene移動
            SceneManager.LoadScene("Start");
            //箱削除
            GameObject[] boxs = GameObject.FindGameObjectsWithTag("box");
            foreach (GameObject box in boxs){
                Destroy(box);
            }
        }
    }
}
