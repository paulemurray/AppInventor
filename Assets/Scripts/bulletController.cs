using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour {

	public GameObject boundary;
		//when the bullet touches something, it checks if it is the boundary and if its not it tells PlayerController that an enemy
		//was killed and then destroys itself and the enemy
    void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject != boundary){
			GameObject.Find("PlayerSprite").GetComponent<PlayerController>().EnemyKilled();
			Destroy(other.gameObject);
			Destroy(this.gameObject);
		}
  }
}
