using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlaySceneSwitch : MonoBehaviour {

	//when the button is pressed, load the game
	void OnMouseEnter(){
		SceneManager.LoadScene("GameScene");
	}
}
