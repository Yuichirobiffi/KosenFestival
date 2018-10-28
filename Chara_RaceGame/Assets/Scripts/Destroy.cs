using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
    private void OnCollisionEnter(Collision other){
        //壁とプレイヤーぶつかったら壁破壊
        Destroy(gameObject);
    }
}
