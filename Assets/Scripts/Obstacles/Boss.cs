using UnityEngine;
using System.Collections;

public class Boss : AbstractBehavior {

	public float shootDelay,lifetime;
	public GameObject projectilePrefab;

	private float timeElapsed = 0f;

	void OnBecameInvisible() {
		Destroy (gameObject);
	}
	void Start(){
		lifetime = Time.time;
	}
	void Update () {
		if (Time.time - lifetime > 7f) {
			Destroy (gameObject);

		}
		if (projectilePrefab != null) {

			var canFire = true;

			if(canFire && (timeElapsed > shootDelay)){
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

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Rocket") {
			GameObject.FindGameObjectWithTag("Player").GetComponent<MainController> ().getEnemy();
			Destroy (gameObject);
		}
	}
}
