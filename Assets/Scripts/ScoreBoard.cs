using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreBoard : MonoBehaviour {
 string sText;
public TextMesh testMesh;
    //Use this for initialization
	void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {
        sText = PlayerController.points +" CO2 Destroyed";//get display text
        testMesh = GetComponent<TextMesh>();//
        testMesh.text = sText;
        Debug.Log(sText);

    }
}
