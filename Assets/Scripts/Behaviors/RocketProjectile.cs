using UnityEngine;
using System.Collections;

public class RocketProjectile : AbstractBehavior {

	public float shootDelay = .5f;
	public GameObject projectilePrefab;

	private float timeElapsed = 0f;
	public int rocket=10;
	public bool canFire = true;

	// Update is called once per frame
	void Update () {

		if (projectilePrefab != null) {

			canFire = inputState.GetButtonValue(inputButtons[0]);

			if(canFire && timeElapsed > shootDelay){
				CreateProjectile(new Vector3 (transform.position.x + 3f, transform.position.y, transform.position.z));
				timeElapsed = 0;
			}

			timeElapsed += Time.deltaTime;
		}
	}

	public void OnClick () {

		if (projectilePrefab != null) {
			
			 canFire = true;
			if (rocket == 0) {
				canFire = false;
			}
			if(canFire){
				CreateProjectile(new Vector3 (transform.position.x + 3f, transform.position.y, transform.position.z));
				timeElapsed = 0;

				rocket--;
			}

			timeElapsed += Time.deltaTime;
		}

	}
	void OnGUI () {
		GUI.Label(new Rect(270, 10, 800, 400), "Rocket: "+rocket);
	}
	public void CreateProjectile(Vector2 pos){
		var clone = Instantiate (projectilePrefab, pos, Quaternion.identity) as GameObject;
		clone.transform.localScale = transform.localScale;
	}
}