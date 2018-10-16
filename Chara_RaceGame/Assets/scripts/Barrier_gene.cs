using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier_gene : MonoBehaviour {

    public GameObject BarrierPrefab;

    private float i, j;

    private float rnd;

    // Use this for initialization
    void Start() {
        for (i = 0.0f; i < 300.0f; i++)
        {
            for (j = 0.0f; j < 3.0f; j++)
            {
                rnd = Random.Range(0.0f, 1.0f);

                GameObject Barrier = Instantiate(BarrierPrefab) as GameObject;

                if (rnd > 0.95f)
                {
                    Barrier.transform.position = new Vector3(0.0f + j, 1.0f, 0.0f + i);
                }
            }

        }
            
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
