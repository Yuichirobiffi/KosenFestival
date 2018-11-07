using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_Text4 : MonoBehaviour {

    public int whereNow;

    public static int p4Char;
    public static int p4DetNot;

	void Start () {
        whereNow = 0;
        p4Char = -1;
        p4DetNot = 1;
	}
	
	void Update () {
        Transform myTransForm = this.transform;
        Vector3 pos = myTransForm.position;

        if (Input.GetKeyDown(KeyCode.J)) {
            Debug.Log(whereNow);
            if(whereNow == 9){
                whereNow = 0;
                GetComponent<RectTransform>().localPosition = new Vector3(-360.0f, 10.0f, 0.0f);
            } else if (whereNow == 4){
                whereNow += 1;
                GetComponent<RectTransform>().localPosition = new Vector3(-360.0f, -210.0f, 0.0f);
            } else {
                whereNow += 1;
                GetComponent<RectTransform>().localPosition += new Vector3(225.0f, 0.0f, 0.0f);
            }
        }
        if (Input.GetKeyDown(KeyCode.H)){
            Debug.Log(whereNow);
            if (whereNow == 0){
                whereNow = 9;
                GetComponent<RectTransform>().localPosition = new Vector3(535.0f, -210.0f, 0.0f);
            } else if (whereNow == 5) {
                whereNow -= 1;
                GetComponent<RectTransform>().localPosition = new Vector3(535.0f, 10.0f, 0.0f);
            } else {
                whereNow -= 1;
                GetComponent<RectTransform>().localPosition -= new Vector3(225.0f, 0.0f, 0.0f);
            }
        }
    }
}
