using UnityEngine;
using System.Collections;

public class CooltimeBlue : MonoBehaviour {

	private Animator anim2;

	// Use this for initialization
	void Start () {
		anim2 = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {

		anim2.SetFloat ("Time", Shield.timeElapsed);

	}
}
