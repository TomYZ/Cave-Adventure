using UnityEngine;
using System.Collections;

public class RocketProjectile : AbstractBehavior {

	public float shootDelay = .5f;
	public GameObject projectilePrefab;

	private float timeElapsed = 0f;

	// Update is called once per frame
	void Update () {

		if (projectilePrefab != null) {

			var canFire = inputState.GetButtonValue(inputButtons[0]);

			if(canFire && timeElapsed > shootDelay){
				CreateProjectile(new Vector3 (transform.position.x + 3f, transform.position.y, transform.position.z));
				timeElapsed = 0;
			}

			timeElapsed += Time.deltaTime;
		}
	}

	public void OnClick () {

		if (projectilePrefab != null) {

			var canFire = true;

			if(canFire){
				CreateProjectile(new Vector3 (transform.position.x + 3f, transform.position.y, transform.position.z));
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