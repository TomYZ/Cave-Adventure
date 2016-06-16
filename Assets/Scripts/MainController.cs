using UnityEngine;
using System.Collections;

public class MainController : MonoBehaviour {
	public float maxspeedUpDown = 5f;
	public float speed;
	public GameObject player;
	public GameObject sheild;
	public float health = 100f;	
	public Buttons[] input;

	private Rigidbody2D rb2d;
	private Animator anim;
	private SpriteRenderer healthBar;
	private Vector3 healthScale;
	private bool ShowThisGUI = false;

	private InputState inputState;

	private float InitX;

	private float t;
	private float velocity;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		inputState = GetComponent<InputState>();
		anim = GetComponent<Animator>();

		healthBar = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<SpriteRenderer>();
		healthScale = healthBar.transform.localScale;

		InitX = gameObject.transform.position.x;

		ShowThisGUI = true;

		velocity = 0;
	}

	// Update is called once per frame
	void Update () {
		if (velocity != 0) {
			if (Time.time - t >= 0.1) {
				velocity = 0;
			}
		}
			rb2d.velocity = new Vector2(speed, velocity * maxspeedUpDown);
			anim.SetFloat ("Speed", Mathf.Abs(velocity));
	}

	public void OnClickUp(){
		velocity = 1;
		t = Time.time;


	}

	public void OnClickDown(){
		velocity = -1;
		t = Time.time;


	}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Edge" || col.gameObject.tag == "Obstacle") {
			if(sheild.GetComponent<Renderer> ().enabled == false)
				UpdateHealthBar ();
		}
	}

	void UpdateHealthBar(){
		health -= 10f;
		ShowThisGUI = true;
		if (health <= 0) {
			Destroy (gameObject);
		}
		healthBar.transform.localScale = new Vector3(healthScale.x * health * 0.01f, 1, 1);
		healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - health * 0.01f);
	}

	void OnGUI () {

		if (ShowThisGUI) {
			GUI.skin.label.normal.textColor = new Vector4 (1,1,1,1);
			GUI.skin.label.fontSize=50;
			GUI.Label(new Rect(10, 10, 800, 400), "Health: "+health);
			GUI.Label(new Rect(500, 10, 800, 400), "Time: "+ (int)Time.time);
		}
	}
}

