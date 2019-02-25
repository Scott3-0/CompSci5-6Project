using UnityEngine;

public class Player : MonoBehaviour {

    public int speed;
    public int runSpeed;

    void Start() {
        transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
    }
	
	void Update () {
        Vector3 movement;
		

        if(Input.GetKey("left shift") == true)
        {
             movement = new Vector3(Input.GetAxis("Horizontal") * runSpeed, 0, Input.GetAxis("Vertical") * runSpeed);
            Debug.Log(runSpeed);
        }
        else
        {
            movement = new Vector3(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);
            Debug.Log(speed);
        }

        transform.GetComponent<Rigidbody>().velocity = movement;
    }
}