using System.Collections;
using UnityEngine;

// A behaviour that is attached to a playable
public class PlayerController : MonoBehaviour
{
	public static int points;
	public static int lives = 3;
	public Rigidbody2D bulletPrefab;
	public Rigidbody2D PlayerBody;
	public static int direction;
	public float bulletSpeed;
	float speed = 0.1f;
	// Called when an enemy is destroyed, counts points
	public void EnemyKilled() {
		points++;
		Debug.Log("Score: " + points);
	}
	//called every frame
	void Update() {
		//moves player by given direction, diretion modified by button scripts
		PlayerBody.transform.Translate(direction* speed, 0, 0);

		//checks if the player is on the edges and stops movement
		if (PlayerBody.transform.position.x <= -3.0f || PlayerBody.transform.position.x >= 3.0f){
				direction = 0;
		} 
	}
	//fires projectile
	public void Fire() {
		Rigidbody2D bullet;
		bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
		bullet.velocity = transform.up * bulletSpeed;
	}
}
