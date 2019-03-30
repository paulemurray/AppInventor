using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatsScreenSwitch : MonoBehaviour {

	//when button is pressed load statistics screen
	void OnMouseEnter(){
		SceneManager.LoadScene("StatsScene");
	}
}
