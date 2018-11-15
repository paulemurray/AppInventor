using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	public static bool bWasShot = false;
	//Called when destroyed
	void OnDestroy() {
		if (!bWasShot){
			PlayerController.lives--;
			Debug.Log("Lives:" + PlayerController.lives);
			bWasShot = false;
		}
	}
}
