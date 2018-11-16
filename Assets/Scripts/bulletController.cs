using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour {

	public GameObject boundary;
    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject != boundary){
			Destroy(other.gameObject);
        	GameObject.Find("PlayerSprite").GetComponent<PlayerController>().EnemyKilled();
			Destroy(this.gameObject);
		}
    }
}
