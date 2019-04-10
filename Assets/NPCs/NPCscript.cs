using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCscript : MonoBehaviour {
    public Transform OrgNPC;
    Transform[] npcs = new Transform[15];
    Vector3 initPos =new Vector3(0f, 0f,0f);
    int[] npcDirX = new int[15];
    int[] npcDirY = new int[15];
    Vector3[] npcMov = new Vector3[15];
    float sped = 0.025f;
    bool[] mov = new bool[15];

    void Start () {
        for(int i = 0; i < 15; i++)
        {
            npcs[i] = OrgNPC;
            npcs[i] = Instantiate(OrgNPC); //these two lines instantiate the npcs from the prefab

            initPos.x = Random.Range(12.5f,73f);
            initPos.y = Random.Range(-66f,7.2f); //lines 21-22 makes them spawn at a random pos in between -100 and 100

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
                    npcDirX[i] = Random.Range(-1, 1);
                    npcDirY[i] = Random.Range(-1, 1); //these two line generate two points, which the game uses to draw a vector
                }
                else
                {
                    npcDirX[i] = 0;
                    npcDirY[i] = 0;
                }
            }
        }
       for(int i = 0; i < 15; i++)
        {
            npcMov[i] = new Vector3(npcDirX[i] * sped, npcDirY[i] * sped, 0f); //draws the vector from the 2 points
        }

       for(int i = 0; i < 15; i++)
        {
            npcs[i].position += npcMov[i]; //adds position
        }
	}
}
