using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public int speed;
    public int runSpeed;
    public GameObject chatPanel;
	
	void Update () {
        Vector3 movement;
		

        if(Input.GetKey("left shift") == true)
             movement = new Vector3(Input.GetAxis("Horizontal") * runSpeed, 0, Input.GetAxis("Vertical") * runSpeed);
        else
            movement = new Vector3(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);

        transform.GetComponent<Rigidbody>().velocity = movement;
        ConvoInit();
    }

    public void ConvoInit()
    {
        Vector3 tomPos = GameObject.Find("Tom").transform.position;
        Vector3 playerPos = GetComponent<Transform>().position;

        if(Vector3.Distance(tomPos, playerPos) <= 10)
        {
            chatPanel.SetActive(true);
            
        }
        else
        {
            chatPanel.SetActive(false);
        }
        if (Input.GetKey(KeyCode.E) == true && Vector3.Distance(tomPos, playerPos) <= 10)
        {
            SceneManager.LoadScene("Tom conversation");
        }
    }
}