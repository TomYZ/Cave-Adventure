using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject target;
	private Transform _t;


	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player");
		_t = target.transform;
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (_t.position.x + 4.7f, 0, transform.position.z);
	}
}
