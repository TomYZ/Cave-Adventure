using UnityEngine;
using System.Collections;

public class Boost : MonoBehaviour {

	private Collider2D target;
	public float boostTime = 2.5f;
	public float boostSpeed = 20f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter2D(Collider2D target)
	{
		this.target = target;
		if (target.gameObject.tag == "Player")
		{


			StartCoroutine("ActivateBoost");
			StartCoroutine("DeActivateBoost");


		}
	}
	IEnumerator ActivateBoost()
	{
		target.gameObject.GetComponent<MainController>().isboost = true;

		target.gameObject.GetComponent<MainController> ().getReward();

		target.gameObject.GetComponent<MainController>().speed = boostSpeed;

		yield return null;

	}

	IEnumerator DeActivateBoost()
	{
		yield return new WaitForSeconds(boostTime);
		target.gameObject.GetComponent<MainController>().isboost = false;
		target.gameObject.GetComponent<MainController>().speed = 10f;

		Destroy(gameObject);
	}
}
