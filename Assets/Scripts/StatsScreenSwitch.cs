using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using SceneManager;

public class StatsScreenSwitch : MonoBehaviour {

	// Use this for initialization
	void OnMouseEnter(){
		SceneManager.LoadScene("StatScene");
	}
}
