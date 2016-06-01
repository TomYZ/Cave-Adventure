using UnityEngine;
using System.Collections;

public class MainController : MonoBehaviour {
	public float maxspeedUpDown;
	public float speed;
	private Rigidbody2D rb2d;
	private Animator anim;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate()
	{
		float verti = Input.GetAxis ("Vertical");
		anim.SetFloat ("Speed", Mathf.Abs(verti));
		rb2d.velocity = new Vector2(speed, verti * maxspeedUpDown);
	}
}

