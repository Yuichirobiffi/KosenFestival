﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Deco4 : MonoBehaviour{

    //public
    public float speed = 0.8f;

    //private
    private Text text;
    private Image image;
    private float time;

    private enum ObjType{
        TEXT,
        IMAGE
    };

    private ObjType thisObjType = ObjType.TEXT;

    void Start(){
        //アタッチしてるオブジェクトを判別
        if (this.gameObject.GetComponent<Image>()){
            thisObjType = ObjType.IMAGE;
            image = this.gameObject.GetComponent<Image>();
        }
        else if (this.gameObject.GetComponent<Text>()){
            thisObjType = ObjType.TEXT;
            text = this.gameObject.GetComponent<Text>();
        }
    }

    void Update(){
        //Player4がスタートボタン押してなければ
        if (StartSceneMover.p4 == 0){
            //オブジェクトのAlpha値を更新
            if (thisObjType == ObjType.IMAGE){
                image.color = GetAlphaColor(image.color);
            } else if (thisObjType == ObjType.TEXT){
                text.color = GetAlphaColor(text.color);
            }
        } else{ //Player4がスタートボタン押したら
            text.color = GetAlphaColorNormal(text.color);
            text.text = "Player4 OK!";
        }
    }

    //Alpha値を更新してColorを返す
    Color GetAlphaColor(Color color){
        time += Time.deltaTime * 5.0f * speed;
        color.a = Mathf.Sin(time) * 0.5f + 0.5f;

        return color;
    }
    //Alpha値を初期化する
    Color GetAlphaColorNormal(Color color){
        color.a = 1.0f;

        return color;
    }
}