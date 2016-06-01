﻿using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour {
	
	public GameObject[] prefabs;
	public float delay = 2.0f;
	public bool active = true;
	public Vector2 delayRange = new Vector2 (1, 2);


	// Use this for initialization
	void Start () {
		ResetDelay ();
		StartCoroutine (EnemyGenerator ());
	}

	IEnumerator EnemyGenerator(){
		yield return new WaitForSeconds (delay);

		if (active) {
			var newTransform = transform;
			Instantiate (prefabs [Random.Range (0, prefabs.Length)], newTransform.position, Quaternion.identity);
			ResetDelay ();
		}
		StartCoroutine (EnemyGenerator ());
	}

	void ResetDelay (){
		delay = Random.Range (delayRange.x, delayRange.y);
	}
}
