using UnityEngine;
using System.Collections;

public class warning_follow : MonoBehaviour {
	public GameObject target;
	public float time;
	public int position;
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player");
		time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		print (position);
		transform.position = new Vector3 (target.transform.position.x+12, position, transform.position.z);
		if (Time.time - time > 0.5f) {
			Destroy (gameObject);
		}
	}
}
