using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCscript : MonoBehaviour {
    public Transform orgnpc;
    Transform[] npcs = new Transform[15];
    Vector3 initPos =new Vector3(0f, 0f,0f);
    int[] npcDirX = new int[15];
    int[] npcDirZ = new int[15];
    Vector3[] npcMov = new Vector3[15];
    float sped = 0.25f;
    bool[] mov = new bool[15];

    void Start () {
        for(int i = 0; i < 15; i++)
        {
            npcs[i] = orgnpc;
            npcs[i] = Instantiate(orgnpc); //these two lines instantiate the npcs from the prefab

            initPos.x = Random.Range(-100,100);
            initPos.y = 15f;
            initPos.z = Random.Range(-100,100); //lines 21-23 makes them spawn in at 15 units up and at a random pos in between -100 and 100

            npcs[i].localPosition = initPos;
            mov[i] = (Random.value >= 0.5f); //sets the move value to a random either true or false
        }
    }

	void Update () {
        if (Time.frameCount % 60 == 0) //moves every 60 frames (60 fps)
        {
            for (int i = 0; i < 15; i++)
            {
                mov[i] = (Random.value >= 0.5f); //sets the move value to a random true or false
                if (mov[i] == true) //if true
                {
                    npcDirX[i] = Random.Range(-100, 100);
                    npcDirZ[i] = Random.Range(-100, 100); //these two line generate two points, which the game uses to draw a vector
                }
                else
                    break; //if move value is false then exit for loop, this makes sure that they npcs only move every 25 frames
            }
        }
       for(int i = 0; i < 15; i++)
        {
            npcMov[i] = new Vector3(npcDirX[i] * sped, 0f, npcDirZ[i] * sped); //draws the vector from the 2 points
        }

       for(int i = 0; i < 15; i++)
        {
            
            npcs[i].GetComponent<Rigidbody>().velocity = npcMov[i]; //assigns this vector as a velocity for the npcs
        }
	}
}
