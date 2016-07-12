using UnityEngine;
using UnityEngine.UI;
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
	public Text scoreText;
	public Text coinText;
	public Text coinCount;
	public Text coinText2;
	public Text killCount;
	public Text killText;
	public Text distanceText;
	public Text distanceCount;
	public Text distanceText2;
	public Text rewardCount;
	public Text rewardText2;


	private Rigidbody2D rb2d;
	private Animator anim;
	private SpriteRenderer healthBar;
	private Vector3 healthScale;
	private bool healthChange = false;
	private float healthChangeTime = 1.2f;
	private InputState inputState;

	private float t;
	private int start = 0;
	private int score;
	private int coin;
	public int coinCou;
	private int killCou;
	private int rewardCou;
	private int distance;
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
		coin = 0;

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
		anim.SetFloat ("Speedup", speed);
		anim.SetBool ("HealthChange", healthChange);
		rb2d.velocity = new Vector2(speed, verti * maxspeedUpDown);
	
		if (Time.time > explosionTime) {
			Destroy (gameObject);
			GenericWindow.manager.Open (2);
		}

		distance = (33 + (int)(transform.position.x));
		distanceText.text = distance.ToString ();


	}

	public void startGame(){
		start = 1;
	}

	void OnCollisionEnter2D (Collision2D col){
		if (isboost == false && healthChange == false)
		{
			if (sheild.GetComponent<Renderer> ().enabled == false) {
				if (col.gameObject.tag == "Edge") {
					health -= 10;
					SoundManager.instance.PlaySound ();
					UpdateHealthBar ();
				}
				if (col.gameObject.tag == "Ghost1") {
					health -= 15;
					SoundManager.instance.PlaySound ();
					UpdateHealthBar ();
				}
				if (col.gameObject.tag == "Ghost2") {
					health -= 15;
					SoundManager.instance.PlaySound ();
					UpdateHealthBar ();
				}
				if (col.gameObject.tag == "Cannon") {
					health -= 10;
					SoundManager.instance.PlaySound ();
					UpdateHealthBar ();
				}
				if (col.gameObject.tag == "Bullet") {
					health -= 20;
					SoundManager.instance.PlaySound ();
					UpdateHealthBar ();
				}
				if (col.gameObject.tag == "BossEdge") {
					health -= 10;
					SoundManager.instance.PlaySound ();
					UpdateHealthBar ();
				}
				if (col.gameObject.tag == "Smoke") {
					health -= 10;
					SoundManager.instance.PlaySound ();
					UpdateHealthBar ();
				}
			}
		}
	}

	void UpdateHealthBar(){

		if (health > 0) {
			healthBar.transform.localScale = new Vector3 (healthScale.x * health * 0.01f, 1, 1);
			healthBar.material.color = Color.Lerp (Color.green, Color.red, 1 - health * 0.01f);

			StartCoroutine("DeActivateHealthChange");
			StartCoroutine("ActivateHealthChange");
		} 

		else if (health <= 0) {
			healthChange = false;
			healthBar.transform.localScale = new Vector3 (0, 1, 1);
			healthBar.material.color = Color.Lerp (Color.green, Color.red, 1 - health * 0.01f);
			explosionTime = Time.time + explosionDelay;

			distanceCount.text = distance.ToString ();
			distanceText2.text = distance.ToString ();
			score = distance + coin + (rewardCou * 50) + (killCou * 100);
			scoreText.text = score.ToString ();
		}
	}

	public void BostHealthBar()
	{
		getReward ();
		if (health <= 80) {
			health += 20f;
			healthBar.transform.localScale = new Vector3 (healthScale.x * health * 0.01f, 1, 1);
			healthBar.material.color = Color.Lerp (Color.green, Color.red, 1 - health * 0.01f);
		}
		else if (health > 80) {
			health = 100f;
			healthBar.transform.localScale = new Vector3 (healthScale.x * health * 0.01f, 1, 1);
			healthBar.material.color = Color.Lerp (Color.green, Color.red, 1 - health * 0.01f);
		}
	}

	public void getDamage(){
		health -= 20;
		UpdateHealthBar ();
	}

	public void getReward(){
		rewardCou += 1;
		rewardCount.text = rewardCou.ToString ();
		rewardText2.text = (rewardCou * 50).ToString ();
	}

	public void getCoin(){
		coin += 10;
		coinCou += 1;
		sound.Play ();
		coinText.text = coinCou.ToString ();
		coinText2.text = coin.ToString ();
		coinCount.text = (coin/10).ToString ();
	}

	public void updateCoin(int val1,int val2){
		coin += 10*val1;
		coinCou += val2;
		sound.Play ();
		coinText.text = coinCou.ToString ();
		coinText2.text = coin.ToString ();
		coinCount.text = (coin/10).ToString ();
	}

	public void getEnemy(){
		killCou += 1;
		killCount.text = killCou.ToString ();
		killText.text = (killCou * 100).ToString ();
	}

	IEnumerator ActivateHealthChange(){
		healthChange = true;
		yield return null;
	}

	IEnumerator DeActivateHealthChange(){
		yield return new WaitForSeconds(healthChangeTime);
		healthChange = false;
	}
}