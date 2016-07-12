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
		//print (position);
		if (position == 10) {
			SoundManager10.instance.PlaySound ();
			transform.position = new Vector3 (target.transform.position.x + 7f, 0, transform.position.z);
		} else if (position == -4) {
			transform.position = new Vector3 (target.transform.position.x + 7f, position, transform.position.z);			
		}
		else {
			transform.position = new Vector3 (target.transform.position.x+13f, position, transform.position.z);
		}

		if (position == 10 && Time.time - time > 2f) {
			Destroy (gameObject);
		} else if (position != 10 && Time.time - time > 0.7f) {
			Destroy (gameObject);
		}
	}
}
