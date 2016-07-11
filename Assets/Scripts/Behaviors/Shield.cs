using UnityEngine;
using System.Collections;

public class Shield : AbstractBehavior {

	public GameObject target;
	private Transform _t;
	private float start_time;
	public static float timeElapsed = 0.0f;
	public float shieldDelay = 2.0f;
	private float duration = 0.5f;

	// Use this for initialization
	void Start () {
		_t = target.transform;
		gameObject.GetComponent<Renderer>().enabled = false;
		start_time = Time.time;
	}

	// Update is called once per frame
	void Update () {
		//var canShield = inputState.GetButtonValue(inputButtons[0]);
		transform.position = new Vector3 (_t.position.x, _t.position.y, transform.position.z);
//		var canshield = inputState.GetButtonValue(inputButtons[0]);
//
//		if (canshield && gameObject.GetComponent<Renderer> ().enabled == false && Time.time - start_time >  timeElapsed+duration) {
//			gameObject.GetComponent<Renderer> ().enabled = true;
//			start_time = Time.time;
//		}
		timeElapsed += Time.deltaTime;
		if (gameObject.GetComponent<Renderer>().enabled == true && Time.time - start_time > duration) {
			gameObject.GetComponent<Renderer>().enabled = false;

		}

	}

	public void OnClick () {
		//var canShield = inputState.GetButtonValue(inputButtons[0]);
		transform.position = new Vector3 (_t.position.x, _t.position.y, transform.position.z);
		if (gameObject.GetComponent<Renderer> ().enabled == false &&  timeElapsed > shieldDelay) {
			gameObject.GetComponent<Renderer> ().enabled = true;
			start_time = Time.time;
			timeElapsed = 0.0f;
		}
//		if (gameObject.GetComponent<Renderer>().enabled == true && Time.time - start_time > duration) {
//			gameObject.GetComponent<Renderer>().enabled = false;
//		}

	}
		
	void OnTriggerEnter2D(Collider2D target){
//		if (target.gameObject.tag != "Player")
//			Destroy (gameObject);
	}
/*	void OnCollisionEnter2D (Collision2D col){
		print ("collide "+col.gameObject.tag);
		if (col.gameObject.tag == "Bullet"&&gameObject.GetComponent<Renderer> ().enabled == false) {
			target.GetComponent<MainController> ().getDamage ();
		}
	}*/
}