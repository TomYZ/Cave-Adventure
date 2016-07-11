using UnityEngine;
using System.Collections;

public class Boss_ElebarRed : MonoBehaviour {

	private float lifeTime;
	public GameObject target;

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
		transform.position = new Vector3 (target.transform.position.x + 2.1f, 4.5f, 0);
	}
}
