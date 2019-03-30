using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backButton : MonoBehaviour {

	//when the button is pressed, load the menu
	void OnMouseEnter(){
		SceneManager.LoadScene("MenuScene");
	}
}
