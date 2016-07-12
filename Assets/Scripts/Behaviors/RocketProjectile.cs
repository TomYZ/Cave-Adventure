using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RocketProjectile : AbstractBehavior {

	public float shootDelay = 1f;
	public GameObject projectilePrefab;
	public bool boostOff=true;
	public bool upgrade=false;
	public Text weaponUpgrade;

	public static float timeElapsed = 0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (projectilePrefab != null) {

			var canFire = inputState.GetButtonValue(inputButtons[0]);

			if(boostOff && canFire && timeElapsed > shootDelay){
				int coin=gameObject.GetComponent<MainController> ().coinCou;
				if (!upgrade && coin > 200) {
					upgrade = true;
					gameObject.GetComponent<MainController> ().updateCoin(1,-200);
					weaponUpgrade.text = "Fireball upgraded!";
				}
				if (upgrade && coin > 5) {
					CreateProjectileUpgrade (new Vector3 (transform.position.x + 1.5f, transform.position.y, transform.position.z));
					gameObject.GetComponent<MainController> ().coinCou = gameObject.GetComponent<MainController> ().coinCou - 5;
				} else {
					CreateProjectile(new Vector3 (transform.position.x + 1.5f, transform.position.y, transform.position.z));
				}
				timeElapsed = 0;
			}

			timeElapsed += Time.deltaTime;
		}
	}

	public void OnClick () {

		if (projectilePrefab != null ) {

			var canFire = true;

			if(boostOff && canFire && timeElapsed > shootDelay){
				int coin=gameObject.GetComponent<MainController> ().coinCou;
				if (!upgrade && coin > 200) {
					upgrade = true;
					gameObject.GetComponent<MainController> ().updateCoin(1,-200);
					weaponUpgrade.text = "Fireball upgraded!";
				}
				if (upgrade && coin > 5) {
					CreateProjectileUpgrade (new Vector3 (transform.position.x + 1.5f, transform.position.y, transform.position.z));
					gameObject.GetComponent<MainController> ().coinCou = gameObject.GetComponent<MainController> ().coinCou - 5;
				} else {
					CreateProjectile(new Vector3 (transform.position.x + 1.5f, transform.position.y, transform.position.z));
				}	
				timeElapsed = 0;
			}

			timeElapsed += Time.deltaTime;
		}
	}

	public void CreateProjectile(Vector3 pos){
		var clone = GameObjectUtil.Instantiate (projectilePrefab, pos) as GameObject;

		clone.transform.localScale = transform.localScale;

	}



	public void CreateProjectileUpgrade(Vector3 pos){
		var clone = GameObjectUtil.Instantiate (projectilePrefab, pos) as GameObject;
		clone.gameObject.GetComponent<Rocket> ().initialVelocity = new Vector2 (75, 10);
		var clone2 = GameObjectUtil.Instantiate (projectilePrefab, pos) as GameObject;
		clone2.gameObject.GetComponent<Rocket> ().initialVelocity = new Vector2 (75, 0);
		var clone3 = GameObjectUtil.Instantiate (projectilePrefab, pos) as GameObject;
		clone3.gameObject.GetComponent<Rocket> ().initialVelocity = new Vector2 (75, -10);
		clone.transform.localScale = transform.localScale;
		clone2.transform.localScale = transform.localScale;
		clone3.transform.localScale = transform.localScale;
		//clone.gameObject.GetComponent<Rocket>().initialVelocity
	}


}


