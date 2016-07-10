using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

	public Vector2 initialVelocity = new Vector2 (70, 0);
	public Rigidbody2D body2d;	

	private float last_position;
	private float explosionTime;
	private bool explosionBool;
	private Animator anim;

	void Awake()
	{
		body2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator>();
	}

	void Start()
	{
		var startVelx = initialVelocity.x * transform.localScale.x;
		body2d.velocity = new Vector2 (startVelx, initialVelocity.y);
		last_position = transform.position.x;
		explosionTime = 1f;
		explosionBool = false;
	}

	void FixedUpdate ()
	{
		if (transform.position.x - last_position > 19) {
			Destroy (gameObject);
		}
		anim.SetBool ("Explosion", explosionBool);
	}
		
	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag != "Coin" && target.gameObject.tag!="Item")

			StartCoroutine("ActivateExplosion");
			StartCoroutine("DeActivateExplosion");			
	}

	IEnumerator ActivateExplosion(){
		explosionBool = true;
		body2d.velocity = new Vector2 (3, initialVelocity.y);
		yield return null;
	}

	IEnumerator DeActivateExplosion(){
		yield return new WaitForSeconds(explosionTime);
		Destroy (gameObject);
	}
}