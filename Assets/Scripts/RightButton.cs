using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour {

	// Use this for initialization
	void OnMouseEnter(){
		PlayerController.direction += 1;
	}

	void OnMouseExit(){
		PlayerController.direction = 0;
	}
}
