using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	
	public string PlayerName = "Mysterious Person";
	
	public GameObject FullPanel;
	public GameObject NameChooser;
	
	public int Money = 350; //this is in cents!!!
	
	public void ChooseName(string newname) {
		PlayerName = newname;
		NameChooser.SetActive(false);
	}
	
	public string FormatMoney() {
		string str = Money.ToString();//TODO: make it not break when money is 0
		str = str.Insert(str.Length-2,".");
		return str;
	}
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
