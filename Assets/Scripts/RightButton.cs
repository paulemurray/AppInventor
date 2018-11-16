using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightButton : MonoBehaviour {

	//when button is pressed increase player direction, when release set back to 0
	void OnMouseEnter(){
		PlayerController.direction += 1;
	}

	void OnMouseExit(){
		PlayerController.direction = 0;
	}
}
