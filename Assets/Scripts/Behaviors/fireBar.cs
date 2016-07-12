using UnityEngine;
using System.Collections;

public class fireBar : MonoBehaviour {

	public GameObject target;
	public bool isUpgrade = false;

	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag("Player");
		gameObject.GetComponent<Renderer> ().enabled = false;
		isUpgrade = false;
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (target.transform.position.x + 0.1f, target.transform.position.y + 1f, transform.position.z);

		if (!isUpgrade) {
			isUpgrade = GameObject.FindGameObjectWithTag ("Player").GetComponent<RocketProjectile> ().upgrade;

		}else{
			int coin = GameObject.FindGameObjectWithTag ("Player").GetComponent<MainController> ().coinCou;
			if (coin >= 10) {
				gameObject.GetComponent<Renderer> ().enabled = true;
			} else {
				gameObject.GetComponent<Renderer> ().enabled = false;
			}
		}
	} 
}
