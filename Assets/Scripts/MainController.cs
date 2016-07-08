using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class MainController : MonoBehaviour {
	public float maxspeedUpDown = 5f;
	public float speed;
	public GameObject sheild;
	public float health = 100f;	
	public bool isboost = false;
	public float boostDuration = 2.5f;
	public AudioSource sound;

	private Rigidbody2D rb2d;
	private Animator anim;
	private SpriteRenderer healthBar;
	private Vector3 healthScale;
	private bool ShowThisGUI = false;
	private bool healthChange = false;
	private InputState inputState;

	private float t;
	private int start = 0;
	private int score = 0;
	private int coin;
	private float explosionDelay = 1.5f;
	private float explosionTime = 100000f;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		inputState = GetComponent<InputState>();
		anim = GetComponent<Animator>();

		healthBar = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<SpriteRenderer>();
		healthScale = healthBar.transform.localScale;

		start = 0;
		score = 0;
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (start == 0) {
			return;
		}

		/*	float verti = Input.GetAxis ("Vertical");
		rb2d.velocity = new Vector2(speed, verti * maxspeedUpDown); */

		float verti = CrossPlatformInputManager.GetAxis ("Vertical");
		anim.SetFloat ("Health", health);
		anim.SetFloat ("Speed", verti);
		rb2d.velocity = new Vector2(speed, verti * maxspeedUpDown);

	
		if (Time.time > explosionTime) {
			Destroy (gameObject);
			GenericWindow.manager.Open (2);
		}
	}

	public void startGame(){
		start = 1;
		ShowThisGUI = true;
	}

	void OnCollisionEnter2D (Collision2D col){
		if (isboost == false && (col.gameObject.tag == "Edge" || col.gameObject.tag == "Obstacle"|| col.gameObject.tag == "Bullet"))
		{
			if (sheild.GetComponent<Renderer> ().enabled == false) {
				if (col.gameObject.tag == "Edge") {
					health -= 10;
				}
				if (col.gameObject.tag == "Obstacle") {
					health -= 20;
				}
				if (col.gameObject.tag == "Bullet") {
					health -= 20;
				}

				UpdateHealthBar ();
			}
		}
	}

	void UpdateHealthBar(){

		if (health > 0) {
			healthBar.transform.localScale = new Vector3 (healthScale.x * health * 0.01f, 1, 1);
			healthBar.material.color = Color.Lerp (Color.green, Color.red, 1 - health * 0.01f);
		} else if (health <= 0) {
			healthBar.transform.localScale = new Vector3 (0, 1, 1);
			healthBar.material.color = Color.Lerp (Color.green, Color.red, 1 - health * 0.01f);
			explosionTime = Time.time + explosionDelay;
		}
	}

	public void BostHealthBar()
	{
		getReward ();
		health = 100f;
		healthBar.transform.localScale = new Vector3(healthScale.x * health * 0.01f, 1, 1);
		healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - health * 0.01f);
	}

	public void getReward(){
		score += 50;
	}
	public void getCoin(){
		coin += 10;
		sound.Play ();
	}
	public void getEnemy(){
		score += 100;
	}

	void OnGUI () {

		if (ShowThisGUI) {
			GUI.color = Color.yellow;
			GUI.skin.box.fontSize = 70;
			GUI.skin.box.fontStyle = FontStyle.Bold;

			GUI.Box(new Rect(1830, 10, 250, 100), "" + (int)(score+33+transform.position.x));
			GUI.Box(new Rect(2285, 10, 250, 100), ""+ coin);
		}
	}

}