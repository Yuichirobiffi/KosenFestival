using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    //壁と人がぶつかったら壊れるやつ
    private void OnCollisionEnter(Collision other){
        if (other.gameObject.tag == "Player"){
            Destroy(gameObject);
        }
    }
}
