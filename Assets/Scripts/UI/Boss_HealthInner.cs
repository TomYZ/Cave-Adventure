using UnityEngine;
using System.Collections;

public class Boss_HealthInner : MonoBehaviour {

	private float lifeTime;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		lifeTime = Time.time;
		if (gameObject.GetComponent<Renderer> ().enabled == false && lifeTime > 2.5f) {
			gameObject.GetComponent<Renderer> ().enabled = true;
		}
	}
}
