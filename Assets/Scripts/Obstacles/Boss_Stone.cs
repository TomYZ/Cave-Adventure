using UnityEngine;
using System.Collections;

public class Boss_Stone : MonoBehaviour {

	public Vector2 initialVelocity;
	public Rigidbody2D body2d;	

	void Awake()
	{
		body2d = GetComponent<Rigidbody2D> ();
	}

	void Start()
	{
		var startVelx = initialVelocity.x * transform.localScale.x;
		body2d.velocity = new Vector2 (startVelx, initialVelocity.y);
	}

	void Update ()
	{
		if (transform.position.x <= -7) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Player") {
		Destroy (gameObject);
			SoundManager4.instance.PlaySound ();
		

		}
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Rocket") {
			Destroy (gameObject);
		}
	}
}
