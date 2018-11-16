using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootButton : MonoBehaviour {

	// Use this for initialization
	void OnMouseEnter(){
		GameObject.Find("PlayerSprite").GetComponent<PlayerController>().Fire();
	}
}
