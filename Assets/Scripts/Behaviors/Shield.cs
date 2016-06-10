﻿using UnityEngine;
using System.Collections;

public class Shield : AbstractBehavior {

	public GameObject target;
	private Transform _t;
	private float start_time;

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
		if (gameObject.GetComponent<Renderer> ().enabled == false && Input.GetKeyDown(KeyCode.X)) {
			gameObject.GetComponent<Renderer> ().enabled = true;
			start_time = Time.time;
		}
		if (gameObject.GetComponent<Renderer>().enabled == true && Time.time - start_time > 2f) {
			gameObject.GetComponent<Renderer>().enabled = false;
		}

	}
		
	void OnTriggerEnter2D(Collider2D target){
//		if (target.gameObject.tag != "Player")
//			Destroy (gameObject);
	}
}