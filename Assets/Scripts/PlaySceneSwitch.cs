using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlaySceneSwitch : MonoBehaviour {

	// Use this for initialization
	void OnMouseEnter(){
		Application.LoadLevel("GameScene");
	}
}
