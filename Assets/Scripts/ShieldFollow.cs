using UnityEngine;
using System.Collections;

public class ShieldFollow : MonoBehaviour {

	public GameObject target;
	private Transform _t;

	// Use this for initialization
	void Start () {
		_t = target.transform;
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (_t.position.x, _t.position.y, transform.position.z);
	}
}
