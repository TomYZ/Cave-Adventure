using UnityEngine;
using System.Collections;

public class Collectable : MonoBehaviour {

	// Use this for initialization
	public static int cointCollected=0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Player") {
			cointCollected++;
			print (cointCollected);
			if (cointCollected % 10 == 0) {
				print ("inside if");
				target.gameObject.GetComponent<RocketProjectile> ().canFire = true;
				target.gameObject.GetComponent<RocketProjectile> ().rocket++; 
			}
			Destroy (gameObject);
		}
	}
}
