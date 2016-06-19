using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public Vector2 initialVelocity;
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
		//transform.Rotate (new Vector3 (0, 90, 0), Space.Self);
	}

	void Update ()
	{
		if (transform.position.y >= 10) {
			Destroy (gameObject);
		}
	}


}