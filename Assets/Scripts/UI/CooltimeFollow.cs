using UnityEngine;
using System.Collections;

public class CooltimeFollow : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player");
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (target.transform.position.x, transform.position.y, transform.position.z);
	}
}
