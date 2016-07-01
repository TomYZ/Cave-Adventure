using UnityEngine;
using System.Collections;

public class CooldownAnimation : MonoBehaviour {

	private Animator anim;
	private static float time;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {
		time = RocketProjectile.timeElapsed;
		anim.SetFloat ("Time", time);
	}
}
