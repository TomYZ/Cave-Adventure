using UnityEngine;
using System.Collections;

public class Boss_EdgeDownRight : MonoBehaviour {

	private float lifeTime;
	public GameObject target;
	public PolygonCollider2D polyCol;

	// Use this for initialization
	void Start () {
		polyCol.enabled = false;
		gameObject.GetComponent<Renderer>().enabled = false;
	}

	// Update is called once per frame
	void Update () {
		lifeTime = Time.time;
		if (polyCol.enabled == false && lifeTime > 3.1f) {
			polyCol.enabled = true;
			gameObject.GetComponent<Renderer> ().enabled = true;
		}
		transform.position = new Vector3 (target.transform.position.x + -2.7f, -4.5f, 0);
	}
}
