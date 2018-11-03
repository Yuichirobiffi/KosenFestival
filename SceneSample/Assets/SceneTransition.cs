using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// http://freesworder.net/unity-scene-change/

public class SceneTransition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Return)) {
			string scene_name = SceneManager.GetActiveScene ().name;
			Debug.Log (scene_name);
			if (scene_name == "Start") {
				SceneManager.LoadScene ("Game");
			} else if (scene_name == "Game") {
				SceneManager.LoadScene ("End");
			} else if (scene_name == "End") {
				SceneManager.LoadScene ("Start");
			}
		}

	}
}
