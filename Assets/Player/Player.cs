﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	
	public int speed = 5;
	
	// Use this for initialization
	void Start () {
		transform.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = new Vector3(Input.GetAxis("Horizontal")*speed,0,Input.GetAxis("Vertical")*speed);
		transform.GetComponent<Rigidbody>().velocity = direction;
	}
}
