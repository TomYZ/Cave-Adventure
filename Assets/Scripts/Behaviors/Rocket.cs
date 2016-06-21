using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

	public Vector2 initialVelocity = new Vector2 (70, 0);
	public Rigidbody2D body2d;	
	private float last_position;


	void Awake()
	{
		body2d = GetComponent<Rigidbody2D> ();
	}

	void Start()
	{
		var startVelx = initialVelocity.x * transform.localScale.x;
		body2d.velocity = new Vector2 (startVelx, initialVelocity.y);
		last_position = transform.position.x;
	}

	void Update ()
	{
		if (transform.position.x - last_position > 43) {
			Destroy (gameObject);
		}
	}
		
	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag != "Coin" && target.gameObject.tag!="Item")
			Destroy (gameObject);
	}
}