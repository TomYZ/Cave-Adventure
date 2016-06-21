using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class MainController : MonoBehaviour {
	public float maxspeedUpDown = 5f;
	public float speed;
	public GameObject player;
	public GameObject sheild;
	public float health = 100f;	
	public Buttons[] input;
	public bool isboost = false;
	public float boostDuration = 2.5f;

	private Rigidbody2D rb2d;
	private Animator anim;
	private SpriteRenderer healthBar;
	private Vector3 healthScale;
	private bool ShowThisGUI = false;

	private InputState inputState;

	private float InitX;

	private float t;
	private float velocity;
	private int start;
	private int score;

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
		start = 0;

		score = 0;
	}

	// Update is called once per frame
	void FixedUpdate () {


		/*	float verti = Input.GetAxis ("Vertical");
		anim.SetFloat ("Speed", Mathf.Abs(verti));
		rb2d.velocity = new Vector2(speed, verti * maxspeedUpDown); */

		float verti = CrossPlatformInputManager.GetAxis ("Vertical");
		anim.SetFloat ("Speed", Mathf.Abs(verti));
		rb2d.velocity = new Vector2(speed, verti * maxspeedUpDown);

	}

	public void startGame(){
		start = 1;

	}
	public void OnClickUp(){

	}

	void OnCollisionEnter2D (Collision2D col){
		if (isboost == false && (col.gameObject.tag == "Edge" || col.gameObject.tag == "Obstacle"|| col.gameObject.tag == "Bullet"))
		{
			if (sheild.GetComponent<Renderer> ().enabled == false) {
				if (col.gameObject.tag == "Edge") {
					health -= 2;
				}
				if (col.gameObject.tag == "Obstacle") {
					health -= 5;
				}
				if (col.gameObject.tag == "Bullet") {
					health -= 5;
				}

				UpdateHealthBar ();
			}
		}
	}

	void UpdateHealthBar(){

		ShowThisGUI = true;
		if (health <= 0) {
			Destroy (gameObject);
		}
		healthBar.transform.localScale = new Vector3(healthScale.x * health * 0.01f, 1, 1);
		healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - health * 0.01f);
	}

	public void BostHealthBar()
	{
		getReward ();
		health = 100f;
		ShowThisGUI = true;
		healthBar.transform.localScale = new Vector3(healthScale.x * health * 0.01f, 1, 1);
		healthBar.material.color = Color.Lerp(Color.green, Color.red, 1 - health * 0.01f);
	}
	public void getReward(){
		score += 50;
	}
	public void getCoin(){
		score += 10;
	}
	public void getEnemy(){
		score += 100;
	}
	void OnGUI () {

		if (ShowThisGUI) {
			GUI.skin.label.normal.textColor = new Vector4 (1,1,1,1);
			GUI.skin.label.fontSize=50;
			GUI.Label(new Rect(10, 10, 800, 400), "Health: "+health);
			GUI.Label(new Rect(300, 10, 800, 400), "Score: "+ (int)(score+33+transform.position.x));
		}
	}

}