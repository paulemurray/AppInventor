using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayScreenSwitch : MonoBehaviour {

	// Use this for initialization
	void OnMouseEnter(){
		Application.LoadLevel("GameScene");
	}
}
