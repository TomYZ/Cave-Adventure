using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	// Use this for initialization
	void OnBecameInvisible() {
		Destroy (gameObject);
	}
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Player") {
			target.gameObject.GetComponent<MainController> ().getCoin();
			Destroy (gameObject);
		}
	}
}
