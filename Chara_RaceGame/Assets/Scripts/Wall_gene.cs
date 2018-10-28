using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_gene : MonoBehaviour {

    public GameObject WallPrefab;
    public GameObject SpeedUpPrefab;
    public GameObject SpeedDownPrefab;

    //定数
    private const int START_LENGTH = 20;　//縦の開始位置
    private const int BOX_NUM = 57;　//箱の出てくる個数
    private const int BOX_SPAN = 5;　//箱の出てくる頻度
    private const int FLOOR_NUM = 92;　//床の出てくる個数
    private const int FLOOR_SPAN = 3;　//床の出てくる頻度

    private int i;　//for文で使う変数
    private int num,ud; //なんか色々数を格納するやつ　前者はなんか色々使ってる　後者はUpかDownを分けるためのやつ

    //横の位置を格納
    private int[] side = {-1,0,1,2,3};

    //箱の縦の位置を格納
    private int[] boxLengthPlus = new int[BOX_NUM];
    private int[] boxLengthMinus = new int[BOX_NUM];

    //床の縦の位置を格納
    private int[] floorLengthPlus = new int[FLOOR_NUM];
    private int[] floorLengthMinus = new int[FLOOR_NUM];


    void Start () {
        //箱の縦の座標を格納
        num = START_LENGTH;
        for (i = 0; i < BOX_NUM; i++){
            boxLengthPlus[i] = num;
            num += BOX_SPAN;
        }

        num = -START_LENGTH;
        for (i = 0; i < BOX_NUM; i++){
            boxLengthMinus[i] = num;
            num -= BOX_SPAN;
        }

        //床の縦の座標を格納
        num = START_LENGTH;
        for (i = 0; i < FLOOR_NUM; i++){
            floorLengthPlus[i] = num;
            num += FLOOR_SPAN;
        }

        num = -START_LENGTH;
        for (i = 0; i < FLOOR_NUM; i++){
            floorLengthMinus[i] = num;
            num -= FLOOR_SPAN;
        }

        //Player1
        for (i = 0;i < BOX_NUM; i++){
            num = Random.Range(0, 6);
            if (num != 5){
                GameObject Wall = Instantiate(WallPrefab) as GameObject;
                Wall.transform.position = new Vector3(side[num], 1, boxLengthPlus[i]);
            }
        }//Player1 Wall

        for (i = 0; i < FLOOR_NUM; i++){
            num = Random.Range(0, 6);
            if (num != 5){
                ud = Random.Range(0, 2);
                if(ud == 0){
                    GameObject SpeedUp = Instantiate(SpeedUpPrefab) as GameObject;
                    SpeedUp.transform.position = new Vector3(side[num], 0.5f, floorLengthPlus[i]);
                } else{
                    GameObject SpeedDown = Instantiate(SpeedDownPrefab) as GameObject;
                    SpeedDown.transform.position = new Vector3(side[num], 0.5f, floorLengthPlus[i]);
                }
            }
        }//Player1 Floor

        //Player2
        for (i = 0; i < BOX_NUM; i++)
        {
            num = Random.Range(0, 6);
            if (num != 5)
            {
                GameObject Wall = Instantiate(WallPrefab) as GameObject;
                Wall.transform.position = new Vector3(boxLengthPlus[i], 1, side[num]);
            }
        }//Player2 Wall

        for (i = 0; i < FLOOR_NUM; i++){
            num = Random.Range(0, 6);
            if (num != 5){
                ud = Random.Range(0, 2);
                if (ud == 0){
                    GameObject SpeedUp = Instantiate(SpeedUpPrefab) as GameObject;
                    SpeedUp.transform.position = new Vector3(floorLengthPlus[i], 0.5f, side[num]);
                }
                else{
                    GameObject SpeedDown = Instantiate(SpeedDownPrefab) as GameObject;
                    SpeedDown.transform.position = new Vector3(floorLengthPlus[i], 0.5f, side[num]);
                }
            }
        }//Player2 Floor

        //Player3
        for (i = 0; i < BOX_NUM; i++){
            num = Random.Range(0, 6);
            if (num != 5){
                GameObject Wall = Instantiate(WallPrefab) as GameObject;
                Wall.transform.position = new Vector3(side[num], 1, boxLengthMinus[i]);
            }
        }//Player3 Wall

        for (i = 0; i < FLOOR_NUM; i++){
            num = Random.Range(0, 6);
            if (num != 5){
                ud = Random.Range(0, 2);
                if (ud == 0){
                    GameObject SpeedUp = Instantiate(SpeedUpPrefab) as GameObject;
                    SpeedUp.transform.position = new Vector3(side[num], 0.5f, floorLengthMinus[i]);
                } else{
                    GameObject SpeedDown = Instantiate(SpeedDownPrefab) as GameObject;
                    SpeedDown.transform.position = new Vector3(side[num], 0.5f, floorLengthMinus[i]);
                }
            }
        }//Player3 Floor

        //Player4
        for (i = 0; i < BOX_NUM; i++){
            num = Random.Range(0, 6);
            if (num != 5){
                GameObject Wall = Instantiate(WallPrefab) as GameObject;
                Wall.transform.position = new Vector3(boxLengthMinus[i], 1, side[num]);
            }
        }//Player4 Wall

        for (i = 0; i < FLOOR_NUM; i++){
            num = Random.Range(0, 6);
            if (num != 5){
                ud = Random.Range(0, 2);
                if (ud == 0){
                    GameObject SpeedUp = Instantiate(SpeedUpPrefab) as GameObject;
                    SpeedUp.transform.position = new Vector3(floorLengthMinus[i], 0.5f, side[num]);
                }
                else{
                    GameObject SpeedDown = Instantiate(SpeedDownPrefab) as GameObject;
                    SpeedDown.transform.position = new Vector3(floorLengthMinus[i], 0.5f, side[num]);
                }
            }
        }//Player4 Floor

    }
}
