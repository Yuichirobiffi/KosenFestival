using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_gene : MonoBehaviour {
    
    //for文で使う用
    private int i;
    //なんか色々使ってる
    private int num;
    //後者はUpかDownを分けるためのやつ
    private int ud;

    //壁とスピード床のプレハブ
    public GameObject WallPrefabX;
    public GameObject WallPrefabZ;
    public GameObject SpeedUpPrefab;
    public GameObject SpeedDownPrefab;

    //定数
    private const int START_LENGTH = 20;　//縦の開始位置
    private const int FLOOR_LENGTH = 5;　//床の幅

    private const float WALL_HIGH = 0.75f;　//壁の高さ
    private const int BOX_NUM = 60;　//壁の出てくる個数
    private const int BOX_SPAN = 3; //壁の出てくる頻度

    private const float SPEED_HIGH = 0.25f;　//スピード床の高さ
    private const int FLOOR_NUM = 90;　//スピード床の出てくる個数
    private const int FLOOR_SPAN = 2;　//スピード床の出てくる頻度

    //横の座標を格納(一応定数)
    private int[] SIDE = {-2,-1,0,1,2};

    //壁の縦の位置を格納
    private int[] boxLengthPlus = new int[BOX_NUM];
    private int[] boxLengthMinus = new int[BOX_NUM];

    //床の縦の位置を格納
    private int[] floorLengthPlus = new int[FLOOR_NUM];
    private int[] floorLengthMinus = new int[FLOOR_NUM];


    void Start () {
        //壁の縦の座標を格納
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
        //スピード床の縦の座標を格納
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

        //Player1 Wall
        for (i = 0;i < BOX_NUM; i++){
            num = Random.Range(0, FLOOR_LENGTH);
            GameObject wall = Instantiate(WallPrefabZ) as GameObject;
            wall.transform.position = new Vector3(SIDE[num], WALL_HIGH, boxLengthPlus[i]);
        }//Player1 Wall

        //Player1 Floor
        for (i = 0; i < FLOOR_NUM; i++){
            num = Random.Range(0, FLOOR_LENGTH);
            //0の時、速度上昇床作成　1の時、速度下降床作成
            ud = Random.Range(0, 2);
            if(ud == 0){
                GameObject speedUp = Instantiate(SpeedUpPrefab) as GameObject;
                speedUp.transform.position = new Vector3(SIDE[num], SPEED_HIGH, floorLengthPlus[i]);
            } else{
                GameObject speedDown = Instantiate(SpeedDownPrefab) as GameObject;
                speedDown.transform.position = new Vector3(SIDE[num], SPEED_HIGH, floorLengthPlus[i]);
            }
        }//Player1 Floor

        //Player2 Wall
        for (i = 0; i < BOX_NUM; i++){
            num = Random.Range(0, FLOOR_LENGTH);
            GameObject wall = Instantiate(WallPrefabX) as GameObject;
            wall.transform.position = new Vector3(boxLengthPlus[i], WALL_HIGH, SIDE[num]);
        }//Player2 Wall

        //Player2 Floor
        for (i = 0; i < FLOOR_NUM; i++){
            num = Random.Range(0, FLOOR_LENGTH);
            //0の時、速度上昇床作成　1の時、速度下降床作成
            ud = Random.Range(0, 2);
            if (ud == 0){
                GameObject speedUp = Instantiate(SpeedUpPrefab) as GameObject;
                speedUp.transform.position = new Vector3(floorLengthPlus[i], SPEED_HIGH, SIDE[num]);
            } else{
                GameObject speedDown = Instantiate(SpeedDownPrefab) as GameObject;
                speedDown.transform.position = new Vector3(floorLengthPlus[i], SPEED_HIGH, SIDE[num]);
            }
        }//Player2 Floor

        //Player3 Wall
        for (i = 0; i < BOX_NUM; i++){
            num = Random.Range(0, FLOOR_LENGTH);
            GameObject wall = Instantiate(WallPrefabZ) as GameObject;
            wall.transform.position = new Vector3(SIDE[num], WALL_HIGH, boxLengthMinus[i]);
        }//Player3 Wall

        //Player3 Floor
        for (i = 0; i < FLOOR_NUM; i++){
            num = Random.Range(0, FLOOR_LENGTH);
            //0の時、速度上昇床作成　1の時、速度下降床作成
            ud = Random.Range(0, 2);
            if (ud == 0){
                GameObject speedUp = Instantiate(SpeedUpPrefab) as GameObject;
                speedUp.transform.position = new Vector3(SIDE[num], SPEED_HIGH, floorLengthMinus[i]);
            } else{
                GameObject speedDown = Instantiate(SpeedDownPrefab) as GameObject;
                speedDown.transform.position = new Vector3(SIDE[num], SPEED_HIGH, floorLengthMinus[i]);
            }
        }//Player3 Floor

        //Player4 Wall
        for (i = 0; i < BOX_NUM; i++){
            num = Random.Range(0, FLOOR_LENGTH);
            GameObject wall = Instantiate(WallPrefabX) as GameObject;
            wall.transform.position = new Vector3(boxLengthMinus[i], WALL_HIGH, SIDE[num]);
        }//Player4 Wall

        //Player4 Floor
        for (i = 0; i < FLOOR_NUM; i++){
            num = Random.Range(0, FLOOR_LENGTH);
            //0の時、速度上昇床作成　1の時、速度下降床作成
            ud = Random.Range(0, 2);
            if (ud == 0){
                GameObject speedUp = Instantiate(SpeedUpPrefab) as GameObject;
                speedUp.transform.position = new Vector3(floorLengthMinus[i], SPEED_HIGH, SIDE[num]);
            } else{
                GameObject speedDown = Instantiate(SpeedDownPrefab) as GameObject;
                speedDown.transform.position = new Vector3(floorLengthMinus[i], SPEED_HIGH, SIDE[num]);
            }
        }//Player4 Floor
    }
}
