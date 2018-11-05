using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitCamera : MonoBehaviour
{
    //　カメラの分割方法
    public enum SplitCameraMode
    {
        horizontal,
        vertical,
        square
    };

    public SplitCameraMode mode;    //　カメラの分割方法

    //　プレイヤーを写すそれぞれのカメラ
    public Camera Player1;
    public Camera Player2;
    public Camera Player3;
    public Camera Player4;

    //　カメラ用の枠
    public Transform waku1;
    public Transform waku2;
    public Transform waku3;
    public Transform waku4;

    // Use this for initialization
    void Start()
    {
        if (mode == SplitCameraMode.square)
        {
            //　４プレイヤー用の4分割
            //　カメラのViewPortRectの変更
            Player1.rect = new Rect(0f, 0.5f, 0.5f, 0.5f);
            Player2.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
            Player3.rect = new Rect(0f, 0f, 0.5f, 0.5f);
            Player4.rect = new Rect(0.5f, 0f, 0.5f, 0.5f);

            //　枠の幅を変更する
            /*
            var waku1Rect = waku1.Find("Bottom").GetComponent<RectTransform>();
            waku1Rect.localScale = new Vector3(waku1Rect.localScale.x, waku1Rect.localScale.y / 2f, waku1Rect.localScale.z);
            waku1Rect = waku1.Find("Right").GetComponent<RectTransform>();
            waku1Rect.localScale = new Vector3(waku1Rect.localScale.x / 2f, waku1Rect.localScale.y, waku1Rect.localScale.z);

            var waku2Rect = waku2.Find("Bottom").GetComponent<RectTransform>();
            waku2Rect.localScale = new Vector3(waku2Rect.localScale.x, waku2Rect.localScale.y / 2f, waku2Rect.localScale.z);
            waku2Rect = waku2.Find("Left").GetComponent<RectTransform>();
            waku2Rect.localScale = new Vector3(waku2Rect.localScale.x / 2f, waku2Rect.localScale.y, waku2Rect.localScale.z);

            var waku3Rect = waku3.Find("Top").GetComponent<RectTransform>();
            waku3Rect.localScale = new Vector3(waku3Rect.localScale.x, waku3Rect.localScale.y / 2f, waku3Rect.localScale.z);
            waku3Rect = waku3.Find("Right").GetComponent<RectTransform>();
            waku3Rect.localScale = new Vector3(waku3Rect.localScale.x / 2f, waku3Rect.localScale.y, waku3Rect.localScale.z);

            var waku4Rect = waku4.Find("Top").GetComponent<RectTransform>();
            waku4Rect.localScale = new Vector3(waku4Rect.localScale.x, waku4Rect.localScale.y / 2f, waku4Rect.localScale.z);
            waku4Rect = waku4.Find("Left").GetComponent<RectTransform>();
            waku4Rect.localScale = new Vector3(waku4Rect.localScale.x / 2f, waku4Rect.localScale.y, waku4Rect.localScale.z);
            */
        }
    }
}
