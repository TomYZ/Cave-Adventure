using UnityEngine;
using System.Collections;

public class RocketProjectile : AbstractBehavior {

	public float shootDelay = 1f;
	public GameObject projectilePrefab;

	public static float timeElapsed = 0f;

	// Use this for initialization
	void Start () {

	}
		
	// Update is called once per frame
	void Update () {
		if (projectilePrefab != null) {

			var canFire = inputState.GetButtonValue(inputButtons[0]);

			if(canFire && timeElapsed > shootDelay){
				CreateProjectile(new Vector3 (transform.position.x + 1.5f, transform.position.y, transform.position.z));
				timeElapsed = 0;
			}

			timeElapsed += Time.deltaTime;
		}
	}

	public void OnClick () {

		if (projectilePrefab != null) {

			var canFire = true;

			if(canFire && timeElapsed > shootDelay){
				CreateProjectile(new Vector3 (transform.position.x + 1.5f, transform.position.y, transform.position.z));
				timeElapsed = 0;
			}

			timeElapsed += Time.deltaTime;
		}
	}


	public void CreateProjectile(Vector3 pos){
		var clone = GameObjectUtil.Instantiate (projectilePrefab, pos) as GameObject;
		clone.transform.localScale = transform.localScale;
	}
}