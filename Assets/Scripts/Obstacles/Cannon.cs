using UnityEngine;
using System.Collections;

public class Cannon :AbstractBehavior {

	public float shootDelay = .5f;
	public GameObject projectilePrefab;

	private float timeElapsed = 0f;

	// Update is called once per frame
	void Update () {

		if (projectilePrefab != null) {

			var canFire = true;

			if(canFire && timeElapsed > shootDelay){
				CreateProjectile(new Vector3 (transform.position.x-2f, transform.position.y+2f, transform.position.z));
				timeElapsed = 0;
			}

			timeElapsed += Time.deltaTime;
		}
	}



	public void CreateProjectile(Vector2 pos){
		var clone = Instantiate (projectilePrefab, pos, Quaternion.identity) as GameObject;
		clone.transform.localScale = transform.localScale;
	}
}
