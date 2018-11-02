using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_gene : MonoBehaviour {

    public GameObject FloorPrefabX;
    public GameObject GoalPrefabX;
    public GameObject FloorPrefabZ;
    public GameObject GoalPrefabZ;

    private float i, j;

	// Use this for initialization
	void Start () {

        for (i=10.0f;i<211.0f;i++)
        {
            //for (j=-1.0f;j<4.0f;j++)
            //{
            if (i == 210.0f)
            {
                GameObject Goal = Instantiate(GoalPrefabX) as GameObject;
                Goal.transform.position = new Vector3(0.0f, 0.0f, 0.0f + i);
            }
            else
            {
                GameObject Floor = Instantiate(FloorPrefabX) as GameObject;
                Floor.transform.position = new Vector3(0.0f, 0.0f, 0.0f + i);
            }
            //}
            
        }
        
        //Goal
        //for (j=-1.0f;j<4.0f;j++)
        //{
            
        //}

        //90度////////////////////////////////////////////////////////////////////
        for (i = 10.0f; i < 211.0f; i++)
        {
            //for (j = -1.0f; j < 4.0f; j++)
            //{
            if (i == 210.0f)
            {
                GameObject Goal = Instantiate(GoalPrefabZ) as GameObject;
                Goal.transform.position = new Vector3(0.0f + i, 0.0f, 0.0f);
            }
            else
            {
                GameObject Floor = Instantiate(FloorPrefabZ) as GameObject;
                Floor.transform.position = new Vector3(0.0f + i, 0.0f, 0.0f);
            }
            //}
        }

        //Goal////////////////////////////////////////////////////////////////////
        //for (j = -1.0f; j < 4.0f; j++)
        //{

        //}

        //180度////////////////////////////////////////////////////////////////////
        for (i = -10.0f; i > -211.0f; i--)
        {
            //for (j = -1.0f; j < 4.0f; j++)
            //{
            if (i == -210.0f)
            {
                GameObject Goal = Instantiate(GoalPrefabX) as GameObject;
                Goal.transform.position = new Vector3(0.0f, 0.0f, 0.0f + i);
            }
            else
            {
                GameObject Floor = Instantiate(FloorPrefabX) as GameObject;
                Floor.transform.position = new Vector3(0.0f, 0.0f, 0.0f + i);
            }
            //}
        }

        //Goal////////////////////////////////////////////////////////////////////
        //for (j = -1.0f; j < 4.0f; j++)
        //{

        //}

        //270度////////////////////////////////////////////////////////////////////
        for (i = -10.0f; i > -211.0f; i--)
        {
            //for (j = -1.0f; j < 4.0f; j++)
            //{
            if (i == -210.0f)
            {
                GameObject Goal = Instantiate(GoalPrefabZ) as GameObject;
                Goal.transform.position = new Vector3(0.0f + i, 0.0f, 0.0f);
            }
            else
            {
                GameObject Floor = Instantiate(FloorPrefabZ) as GameObject;
                Floor.transform.position = new Vector3(0.0f + i, 0.0f, 0.0f);
            }
            //}
        }

        //Goal////////////////////////////////////////////////////////////////////
        //for (j = -1.0f; j < 4.0f; j++)
        //{

        //}
    }

}
