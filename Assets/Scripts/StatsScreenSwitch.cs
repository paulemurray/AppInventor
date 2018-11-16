using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using SceneManager;

public class StatsScreenSwitch : MonoBehaviour {

	// Use this for initialization
	void OnMouseEnter(){
		SceneManager.LoadScene("StatScene");
        Debug.Log("test");
    }
}
