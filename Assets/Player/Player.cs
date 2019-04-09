using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public int speed;
    public int runSpeed;
    public GameObject chatPanel;
	
	void Update () {
        Vector3 movement;
		

        if(Input.GetKey("left shift") == true) //the run option, uses the left shift key to change speed
             movement = new Vector3(Input.GetAxis("Horizontal") * runSpeed /*uses a & d keys*/, 0, Input.GetAxis("Vertical") * runSpeed /*uses w & s keys*/); //run Vector3
        else
            movement = new Vector3(Input.GetAxis("Horizontal") * speed /*uses a & d keys*/, 0, Input.GetAxis("Vertical") * speed /*uses w & s keys*/); //walk Vector3

        transform.GetComponent<Rigidbody>().velocity = movement; //assigns the input variable to the gameObject as a velocity
        ConvoInit();
    }

    public void ConvoInit()
    {
        Vector3 tomPos = GameObject.Find("Tom").transform.position; //gets position of tom
        Vector3 playerPos = GetComponent<Transform>().position; //gets position of the player

        if(Vector3.Distance(tomPos, playerPos) <= 10) //forms a line segment using the two points
        {
            chatPanel.SetActive(true); //shows the 'E' panel
            
        }
        else
        {
            chatPanel.SetActive(false); //makes the 'E' panel dissapear
        }
        if (Input.GetKey(KeyCode.E) == true && Vector3.Distance(tomPos, playerPos) <= 10) //checks to make sure "E" key is pressed and that you are less than 11 units away from Tom
        {
            SceneManager.LoadScene("Tom conversation"); //Opens the scene with Tom
        }
    }
}