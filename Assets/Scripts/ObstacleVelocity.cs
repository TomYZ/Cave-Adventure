using UnityEngine;
using System.Collections;

public class ObstacleVelocity : MonoBehaviour {

	public Vector2 velocity = Vector2.zero;


	private Rigidbody2D rb2d;

	void Awake(){
		rb2d = GetComponent<Rigidbody2D>();

	}

	void FixedUpdate(){
		rb2d.velocity = velocity;
	}

	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Player") {
			
			Destroy (gameObject);

		}

			
	}
	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Rocket") {
			Destroy (gameObject);
		}
	}

}
