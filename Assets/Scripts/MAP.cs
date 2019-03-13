using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MAP : MonoBehaviour {

    public Image Map;
    public Button libertyville;

	void Start (){
    }
	
	void Update () 
    {
        //Move the map
        Vector2 tempV = new Vector2(-Input.GetAxis("Horizontal")*2, -Input.GetAxis("Vertical")*2);
        Map.rectTransform.anchoredPosition += tempV;

        //Zoom the map
        Map.GetComponent<RectTransform>().offsetMin += new Vector2(-Input.GetAxis("Mouse ScrollWheel")*200, -Input.GetAxis("Mouse ScrollWheel")*200);
        Map.GetComponent<RectTransform>().offsetMax += new Vector2(Input.GetAxis("Mouse ScrollWheel")*200, Input.GetAxis("Mouse ScrollWheel")*200);
    }
}
