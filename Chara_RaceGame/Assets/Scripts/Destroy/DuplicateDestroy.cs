﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateDestroy : MonoBehaviour {
    //かぶったら床系(速度上昇、速度減少)削除する
    private void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "wall"){
            Destroy(gameObject);
        }
    }
}
