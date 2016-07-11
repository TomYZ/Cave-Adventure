using UnityEngine;
using System.Collections;

public class Boss_HealthBar : MonoBehaviour {

	public GameObject target;
	private Transform _t;

	// Use this for initialization
	void Start () {
		_t = target.transform;
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (_t.position.x + 10.9f, _t.position.y + 1.5f, 0);
	}
}