using UnityEngine;
using System.Collections;

public class MainController : MonoBehaviour {
	public float maxspeedUpDown;
	public float speed;
	private Rigidbody2D rb2d;
	private Animator anim;
	public GameObject player;

	private SpriteRenderer healthBar;
	private Vector3 healthScale;	
	public float health = 100f;	

	private bool ShowThisGUI = false;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();

		healthBar = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<SpriteRenderer>();
		healthScale = healthBar.transform.localScale;

		ShowThisGUI = true;
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
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Edge" || col.gameObject.tag == "Obstacle") {
			UpdateHealthBar ();
		}
	}
	void UpdateHealthBar(){
		health -= 10f;
		ShowThisGUI = true;
		if (health == 0) {
			Destroy (player);
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

