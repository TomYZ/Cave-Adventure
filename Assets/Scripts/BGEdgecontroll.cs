using UnityEngine;
using System.Collections;
using System;

public class BGEdgecontroll : MonoBehaviour {


	public GameObject target;
	private Transform _t;
	private float threshold = 54.8f;
	private float last_position = -35.3f; //target's last postion
	// Use this for initialization
	void Start () {
		_t = target.transform;
		last_position = _t.position.x;
	}

	// Update is called once per frame
	void Update () {
		if (_t.position.x > threshold+last_position) {
			transform.position = new Vector3 (_t.position.x + 35.3f, 0, transform.position.z);
			last_position = _t.position.x;
		}
	}
		

}
