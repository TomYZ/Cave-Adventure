using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

	public Vector2 initialVelocity = new Vector2 (60, 0);
	public Rigidbody2D body2d;	
	public CircleCollider2D circleCol;

	private float last_position;
	private float explosionTime;
	private float explGhost1Time;
	private float explGhost2Time;
	private float explCannonTime;
	private float explCannonballTime;
	private float explBossTime;
	private bool explosionBool;
	private bool explosionGhost1;
	private bool explosionGhost2;
	private bool explosionCannon;
	private bool explosionCannonball;
	private bool explosionBoss;
	private Animator anim;

	void Awake()
	{
		body2d = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator>();
	}

	void Start()
	{
		var startVelx = initialVelocity.x * transform.localScale.x;
		body2d.velocity = new Vector2 (startVelx, initialVelocity.y);
		last_position = transform.position.x;
		explosionTime = 1f;
		explGhost1Time = 1.34f;
		explGhost2Time = 1f;
		explCannonTime = 1.34f;
		explCannonballTime = 1.34f;
		explBossTime = 1.34f;
		explosionBool = false;
		explosionGhost1 = false;
		explosionGhost2 = false;
		explosionCannon = false;
		explosionCannonball = false;
		explosionBoss = false;
	}

	void FixedUpdate ()
	{
		if (transform.position.x - last_position > 19) {
			Destroy (gameObject);
		}
		anim.SetBool ("Explosion", explosionBool);
		anim.SetBool ("Explosion2", explosionGhost1);
		anim.SetBool ("Explosion3", explosionGhost2);
		anim.SetBool ("Explosion4", explosionCannon);
		anim.SetBool ("Explosion5", explosionCannonball);
		anim.SetBool ("Explosion6", explosionBoss);
	}
		
	void OnTriggerEnter2D(Collider2D target){

		switch (target.gameObject.tag) {
			case "Edge":
				StartCoroutine ("ActivateExplosion");
				StartCoroutine ("DeActivateExplosion");
				break;
			case "Ghost1":
				StartCoroutine ("ActivateExplosion2");
				StartCoroutine ("DeActivateExplosion2");
				break;
			case "Ghost2":
				StartCoroutine ("ActivateExplosion3");
				StartCoroutine ("DeActivateExplosion3");
				break;
			case "Cannon":
				StartCoroutine ("ActivateExplosion4");
				StartCoroutine ("DeActivateExplosion4");
				break;
			case "Bullet":
				StartCoroutine ("ActivateExplosion5");
				StartCoroutine ("DeActivateExplosion5");
				break;
			case "Boss":
				StartCoroutine ("ActivateExplosion6");
				StartCoroutine ("DeActivateExplosion6");
				break;
			case "BossEdge":
				StartCoroutine ("ActivateExplosion7");
				StartCoroutine ("DeActivateExplosion7");
				break;
		}
	}

	IEnumerator ActivateExplosion(){
		explosionBool = true;
		body2d.isKinematic = true;
		circleCol.enabled = false;
		body2d.velocity = new Vector2 (1, initialVelocity.y);
		yield return null;
	}

	IEnumerator DeActivateExplosion(){
		yield return new WaitForSeconds(explosionTime);
		Destroy (gameObject);
	}

	IEnumerator ActivateExplosion2(){
		explosionGhost1 = true;
		body2d.isKinematic = true;
		circleCol.enabled = false;
		body2d.velocity = new Vector2 (6, initialVelocity.y);
		yield return null;
	}

	IEnumerator DeActivateExplosion2(){
		yield return new WaitForSeconds(explGhost1Time);
		Destroy (gameObject);
	}

	IEnumerator ActivateExplosion3(){
		explosionGhost2 = true;
		body2d.isKinematic = true;
		circleCol.enabled = false;
		body2d.velocity = new Vector2 (7, initialVelocity.y);
		yield return null;
	}

	IEnumerator DeActivateExplosion3(){
		yield return new WaitForSeconds(explGhost2Time);
		Destroy (gameObject);
	}

	IEnumerator ActivateExplosion4(){
		explosionCannon = true;
		body2d.isKinematic = true;
		circleCol.enabled = false;
		body2d.velocity = new Vector2 (2, initialVelocity.y);
		yield return null;
	}

	IEnumerator DeActivateExplosion4(){
		yield return new WaitForSeconds(explCannonTime);
		Destroy (gameObject);
	}

	IEnumerator ActivateExplosion5(){
		explosionCannonball = true;
		body2d.isKinematic = true;
		circleCol.enabled = false;
		body2d.velocity = new Vector2 (6.5f, initialVelocity.y);
		yield return null;
	}

	IEnumerator DeActivateExplosion5(){
		yield return new WaitForSeconds(explCannonballTime);
		Destroy (gameObject);
	}

	IEnumerator ActivateExplosion6(){
		explosionBoss = true;
		body2d.isKinematic = true;
		circleCol.enabled = false;
		body2d.velocity = new Vector2 (7, initialVelocity.y);
		yield return null;
	}

	IEnumerator DeActivateExplosion6(){
		yield return new WaitForSeconds(explBossTime);
		Destroy (gameObject);
	}

	IEnumerator ActivateExplosion7(){
		explosionBool = true;
		body2d.isKinematic = true;
		circleCol.enabled = false;
		body2d.velocity = new Vector2 (7, initialVelocity.y);
		yield return null;
	}

	IEnumerator DeActivateExplosion7(){
		yield return new WaitForSeconds(explosionTime);
		Destroy (gameObject);
	}
}