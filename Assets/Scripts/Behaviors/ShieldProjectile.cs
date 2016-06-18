using UnityEngine;
using System.Collections;

public class ShieldProjectile : AbstractBehavior {

	public float shieldDelay = 3f;
	public GameObject projectilePrefab;

	public GameObject target;
	private Transform _t;

	private float timeElapsed = 0f;


	// Update is called once per frame
	void Update () {

		if (projectilePrefab != null) {

			var canShield = inputState.GetButtonValue(inputButtons[0]);

			if(canShield && timeElapsed > shieldDelay){

				CreateProjectile(transform.position);
				timeElapsed = 0;
			}

			timeElapsed += Time.deltaTime;
		}


	}

	public void CreateProjectile(Vector2 pos){
		var clone = Instantiate (projectilePrefab, pos, Quaternion.identity) as GameObject;

		_t = target.transform;
		transform.position = new Vector3 (_t.position.x, _t.position.y, transform.position.z);
	}
}