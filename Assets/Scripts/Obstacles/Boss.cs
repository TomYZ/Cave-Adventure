using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour {

	public float shootDelay, smokeDelay, lifetime;
	public GameObject projectilePrefab;
	public GameObject smokePrefab;
	public GameObject target;
	public Rigidbody2D body2d;	
	public PolygonCollider2D polyCol;
	public float health = 100f;	

	private Animator anim;
	private SpriteRenderer healthBar;
	private Vector3 healthScale;
	private float timeElapsed = 0f;
	private float lifeTime = 0f;
	private float moveUporDown=0.01f;
	private float bossPosY;
	private bool isAttack = false;
	private bool isSmoke = false;
	private float timeElapsed2 = 0f;

	void Awake(){
		anim = GetComponent<Animator>();
		body2d = GetComponent<Rigidbody2D> ();
		target = GameObject.FindGameObjectWithTag("Player");
	}

	void Start(){
		bossPosY = target.transform.position.y;
		polyCol.enabled = false;
		healthBar = GameObject.FindGameObjectWithTag("BossHealthBar").GetComponent<SpriteRenderer>();
		healthScale = healthBar.transform.localScale;
	}

	void Update () {
		lifeTime = Time.time;
		anim.SetFloat ("Time", timeElapsed);
		anim.SetFloat ("LifeTime", lifeTime);
		anim.SetFloat ("Health", health);

		if (polyCol.enabled == false && lifeTime > 2.5) {
			polyCol.enabled = true;
		}
		if (isSmoke == false && lifeTime > 4.9){
			isSmoke = true;
		}
		if (isAttack == false && lifeTime > 12){
			isAttack = true;
		}
			
		bossPosY += moveUporDown;
		transform.position = new Vector3 (target.transform.position.x + 11.2f, bossPosY, 0);

		if (gameObject.transform.position.y > 1.5f || gameObject.transform.position.y < -1.7f) {
			moveUporDown *= -1;
		}

		if (projectilePrefab != null) {

			if(isAttack && (timeElapsed > shootDelay)){

				StartCoroutine("ActivateAttack");
				StartCoroutine("DeActivateAttack");
		
				timeElapsed = 0;
			}
			timeElapsed += Time.deltaTime;
		}

		if (smokePrefab != null) {

			if(isSmoke && (timeElapsed2 > smokeDelay)){
				CreateSmoke(new Vector3 (transform.position.x - 2.2f, transform.position.y + 1.2f, transform.position.z));
				CreateSmoke(new Vector3 (transform.position.x - 2.6f, transform.position.y + 0.6f, transform.position.z));
				CreateSmoke(new Vector3 (transform.position.x - 2.4f, transform.position.y + 0.0f, transform.position.z));
				CreateSmoke(new Vector3 (transform.position.x - 2.8f, transform.position.y - 0.6f, transform.position.z));
				timeElapsed2 = 0;
			}
			timeElapsed2 += Time.deltaTime;
		}
	}

	public void CreateProjectile(Vector2 pos){
		var clone = Instantiate (projectilePrefab, pos, Quaternion.identity) as GameObject;
		clone.transform.localScale = transform.localScale;
	}

	public void CreateSmoke(Vector2 pos){
		var clone = Instantiate (smokePrefab, pos, Quaternion.identity) as GameObject;
		clone.transform.localScale = transform.localScale;
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.gameObject.tag == "Rocket") {
			SoundManager5.instance.PlaySound ();
			health -= 10;
			UpdateHealthBar ();
		}
	}

	void UpdateHealthBar(){

		if (health > 0) {
			healthBar.transform.localScale = new Vector3 (healthScale.x * health * 0.01f, 1, 1);
			healthBar.material.color = Color.Lerp (Color.green, Color.red, 1 - health * 0.01f);
		} 

		else if (health <= 0) {
			healthBar.transform.localScale = new Vector3 (0, 1, 1);
			healthBar.material.color = Color.Lerp (Color.green, Color.red, 1 - health * 0.01f);

			StartCoroutine("ActivateDeath");
			StartCoroutine("DeActivateDeath");
		}
	}

	IEnumerator ActivateDeath(){

		yield return null;
	}

	IEnumerator DeActivateDeath(){
		yield return new WaitForSeconds(1.1f);
		GameObject.FindGameObjectWithTag("Player").GetComponent<MainController> ().getEnemy();
		Destroy (gameObject);
	}

	IEnumerator ActivateAttack(){

		yield return null;
	}

	IEnumerator DeActivateAttack(){
		yield return new WaitForSeconds(0.5f);
		int random = Random.Range (-2, 2);
		int random2 = Random.Range (-2, 2);
		CreateProjectile(new Vector3 (transform.position.x - 2.8f, transform.position.y + random, transform.position.z));
		CreateProjectile(new Vector3 (transform.position.x - 1.5f, transform.position.y + random2, transform.position.z));
	}
}
