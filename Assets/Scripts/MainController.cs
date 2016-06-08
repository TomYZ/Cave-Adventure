using UnityEngine;
using System.Collections;

public class MainController : MonoBehaviour {
	public float maxspeedUpDown = 5f;
	public float speed;
	public GameObject player;
	public float health = 100f;	
	public Buttons[] input;

	private Rigidbody2D rb2d;
	private Animator anim;
	private SpriteRenderer healthBar;
	private Vector3 healthScale;
	private bool ShowThisGUI = false;
	private InputState inputState;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		inputState = GetComponent<InputState>();
		anim = GetComponent<Animator>();

		healthBar = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<SpriteRenderer>();
		healthScale = healthBar.transform.localScale;

		ShowThisGUI = true;
	}

	// Update is called once per frame
	void Update () {
		float verti = Input.GetAxis ("Vertical");
		rb2d.velocity = new Vector2(speed, verti * maxspeedUpDown);
		anim.SetFloat ("Speed", Mathf.Abs(verti));

		// var up = inputState.GetButtonValue (input [0]);
		// var down = inputState.GetButtonValue (input [1]);

		// var temSpeed = maxspeedUpDown;
		// var velY = temSpeed * (float)inputState.direction;

		// if (up || down) {
		// 	velY *= down ? -1 : 1;
		// } else {
		//	velY = 0;
		//}
		//rb2d.velocity = new Vector2(speed, velY);

	}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Edge" || col.gameObject.tag == "Obstacle") {
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
			
			GUI.Label(new Rect(10, 10, 100, 20), "Health: "+health);
		}
	}
}

