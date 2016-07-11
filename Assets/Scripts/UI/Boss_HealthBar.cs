using UnityEngine;
using System.Collections;

public class Boss_HealthBar : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Boss");
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (target.transform.position.x+10.9f, target.transform.position.y+1.5f, transform.position.z);
	}
}