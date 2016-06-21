using UnityEngine;
using System.Collections;

public class Ghost_left : MonoBehaviour {

	public Transform target;
	public float speed = 3f;
	public float attack1Range = 3f;
	public int attack1Damage = 10;
	public float timeBetweenAttacks;

	private int start;
	private float start_time;
	private float moveUporDown=0.2f;
	private float timeToChange=0;
	// Use this for initialization
	void OnBecameInvisible() {
		Destroy (gameObject);
	}
	void Start ()
	{
		start = 0;
		timeToChange = Time.time;
		start_time = Time.time;
	}
	public void startGame(){
		start = 1;
	}
	// Update is called once per frame
	void Update ()
	{
		
		//		if (start == 0)
		//			return;
		if (gameObject.transform.position.y>3f||gameObject.transform.position.y<-3f) {
			moveUporDown*=-1;
			//timeToChange = Time.time;
		}

		MoveToPlayer ();



	}

	public void MoveToPlayer ()
	{
		//rotate to look at player
		//		transform.LookAt (target.position);
		//		transform.Rotate (new Vector3 (0, 90, 0), Space.Self);

		//move towards player
		//		if (Vector3.Distance (transform.position, target.position) > attack1Range) 
		//		{
		//			transform.Translate (new Vector3 (0, moveUporDown, 0));
		//			print (moveUporDown);
		//		}
		transform.Translate (new Vector3 (-0.1f, 0, 0));

	}

	void OnCollisionEnter2D(Collision2D target){
		if (target.gameObject.tag == "Player") {
			Destroy (gameObject);
		}
	}
	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Rocket") {
			GameObject.FindGameObjectWithTag("Player").GetComponent<MainController> ().getEnemy();
			Destroy (gameObject);
		}
	}
}

