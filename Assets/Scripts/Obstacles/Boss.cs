using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

	public float shootDelay,lifetime;
	public GameObject projectilePrefab;
	public GameObject target;

	private float timeElapsed = 0f;

	private float moveUporDown=0.01f;
	private float bossPosY;

	void OnBecameInvisible() {
		Destroy (gameObject);
	}

	void Start(){
		lifetime = Time.time;
		target = GameObject.FindGameObjectWithTag("Player");
		bossPosY = transform.position.y;
	}

	void Update () {
		bossPosY += moveUporDown;
		transform.position = new Vector3 (target.transform.position.x + 10.7f, bossPosY, transform.position.z);

		if (gameObject.transform.position.y > 1.7f || gameObject.transform.position.y < -1.8f) {
			moveUporDown *= -1;
		}


		if (Time.time - lifetime > 100f) {
			Destroy (gameObject);

		}
		if (projectilePrefab != null) {

			var canFire = true;

			if(canFire && (timeElapsed > shootDelay)){
				CreateProjectile(new Vector3 (transform.position.x-2.5f, transform.position.y+1f, transform.position.z));
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
			SoundManager5.instance.PlaySound ();

		}
	}
}
