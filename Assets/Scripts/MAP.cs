using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MAP : MonoBehaviour {

    public Image Map;
    public Button Libertyville;

	void Start (){
    }
	
	void Update () 
    {
        //Move the map
        Vector2 tempV = new Vector2(-Input.GetAxis("Horizontal") * 4, -Input.GetAxis("Vertical") * 4);
        Map.rectTransform.anchoredPosition += tempV;
		//Zoom the map
		//I hope we never have to resurrect this beast
		/*
        if (Map.GetComponent<RectTransform>().anchorMin.x <= 1.5 && Map.GetComponent<RectTransform>().anchorMin.y <= 1.5 &&
            Map.GetComponent<RectTransform>().anchorMax.x >= 1 && Map.GetComponent<RectTransform>().anchorMax.y >= 1
            && Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            Map.GetComponent<RectTransform>().anchorMin += new Vector2(-Input.GetAxis("Mouse ScrollWheel"), -Input.GetAxis("Mouse ScrollWheel"));
            Map.GetComponent<RectTransform>().anchorMax += new Vector2(Input.GetAxis("Mouse ScrollWheel"), Input.GetAxis("Mouse ScrollWheel"));
            //Libertyville.GetComponent<RectTransform>().anchorMin = Map.GetComponent<RectTransform>().anchorMin;
            //Libertyville.GetComponent<RectTransform>().anchorMax = Map.GetComponent<RectTransform>().anchorMax;
        }

        else if (Map.GetComponent<RectTransform>().anchorMin.x >= -2.7 && Map.GetComponent<RectTransform>().anchorMin.y >= -2.7 &&
                Map.GetComponent<RectTransform>().anchorMax.x <= 3.7 && Map.GetComponent<RectTransform>().anchorMax.y <= 3.7 &&
                Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            Map.GetComponent<RectTransform>().anchorMin += new Vector2(-Input.GetAxis("Mouse ScrollWheel"), -Input.GetAxis("Mouse ScrollWheel"));
            Map.GetComponent<RectTransform>().anchorMax += new Vector2(Input.GetAxis("Mouse ScrollWheel"), Input.GetAxis("Mouse ScrollWheel"));
            //Libertyville.GetComponent<RectTransform>().anchorMin = Map.GetComponent<RectTransform>().anchorMin;
            //Libertyville.GetComponent<RectTransform>().anchorMax = Map.GetComponent<RectTransform>().anchorMax;
        }
		*/
		//Sane version
		if(Input.GetAxis("Mouse ScrollWheel")>0){
			Vector2 oldScale = Map.GetComponent<RectTransform>().localScale;
			Map.GetComponent<RectTransform>().localScale = new Vector2(oldScale.x + 0.5f,oldScale.y + 0.5f);
		} else if(Input.GetAxis("Mouse ScrollWheel")<0){
			Vector2 oldScale = Map.GetComponent<RectTransform>().localScale;
			Map.GetComponent<RectTransform>().localScale = new Vector2(oldScale.x - 0.5f,oldScale.y - 0.5f);
		}
        
    }
}
