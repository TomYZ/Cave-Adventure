using UnityEngine;
using System.Collections;

public class heathUp : MonoBehaviour {

	private Collider2D target;
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

			target.gameObject.GetComponent<MainController>().BostHealthBar();
			Destroy (gameObject);


		}
	}
}
