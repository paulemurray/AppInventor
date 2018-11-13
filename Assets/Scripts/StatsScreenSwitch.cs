using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StatsScreenSwitch : MonoBehaviour {

	// Use this for initialization
	void OnMouseEnter(){
		SceneManager.LoadScene("StatScene");
	}
}
