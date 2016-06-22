using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	public Vector3 offset;
	public GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.transform.position + offset;
	}
}
