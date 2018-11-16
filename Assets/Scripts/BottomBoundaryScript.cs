using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBoundaryScript : MonoBehaviour {
	//called when an object enters the boundary, reduces player points by one
	 void OnTriggerEnter2D(Collider2D other){
		PlayerController.lives--;	
	}
}
