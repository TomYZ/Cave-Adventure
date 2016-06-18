using UnityEngine;
using System.Collections;

public class EnemyOccurs : MonoBehaviour {

	private float start_time;
	public GameObject projectilePrefab;

	// Use this for initialization
	void Start () {
		start_time = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - start_time > 4) {
			start_time = Time.time;

				CreateProjectile(new Vector3 (transform.position.x + 20f,1.5f, transform.position.z));

		}
	}

	public void CreateProjectile(Vector2 pos){
		var clone = Instantiate (projectilePrefab, pos, Quaternion.identity) as GameObject;
		//clone.transform.localScale = transform.localScale;
	}
}
