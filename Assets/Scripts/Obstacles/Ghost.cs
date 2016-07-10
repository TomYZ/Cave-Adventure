using UnityEngine;
using System.Collections;

public class Ghost : MonoBehaviour {
	
	public Transform target;
	public float speed = 3f;
	public float attack1Range = 3f;
	public int attack1Damage = 10;
	public float timeBetweenAttacks;

	private int start;
	// Use this for initialization
	void Start ()
	{
		start = 0;
	}
	public void startGame(){
		start = 1;
	}
	// Update is called once per frame
	void Update ()
	{
		if (start == 0)
			return;
		MoveToPlayer ();
	}

	public void MoveToPlayer ()
	{
		//rotate to look at player
		transform.LookAt (target.position);
		transform.Rotate (new Vector3 (0, 90, 0), Space.Self);

		//move towards player
		if (Vector3.Distance (transform.position, target.position) > attack1Range) 
		{
			transform.Translate (new Vector3 (speed * Time.deltaTime, 0, 0));
		}
	}

	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Player") {
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Rocket") {
			Destroy (gameObject);
			SoundManager5.instance.PlaySound ();


		}
	}
}

