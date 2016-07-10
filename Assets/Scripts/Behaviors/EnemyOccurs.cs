using UnityEngine;
using System.Collections;

public class EnemyOccurs : MonoBehaviour {

	private float randomNum,last_position,enemy_delay;
	private int distance_slot,stage_slot;
	public GameObject Ghost_up_prefab,Ghost_left_prefab,Cannon_prefab;
	private int flag;

	// Use this for initialization
	void Start () {
		flag = 0;
		distance_slot = 200;
		stage_slot = 50;
		last_position = -5f;
		enemy_delay = 10f;
	}
	
	// Update is called once per frame
	void Update () {
		int position_x = ((int)transform.position.x)%(3*distance_slot);

		if (transform.position.x - last_position > enemy_delay) {// every 10 distance, enemy will appear


			if (position_x > 0 && position_x < distance_slot) {// Stage 1 : Only one kind of enemy will appear
				if (flag != 1) {
					randomNum = Random.Range(1,4);
				}
				flag=1;

				int position = position_x ;
				if (position > 0) {// In the second stage, enemy occurs. (first stage edges occurs)

					//--
					randomNum = 1;
					
					if (randomNum == 1) {// Up ghost
						CreateEnemyUp ();
					}
					if (randomNum == 2) {// Left ghost
						CreateEnemyLeft ();
					}
					if (randomNum == 3) {// Cannon
						CreateEnemyCannon ();
					}
				}


			}

			if (position_x > distance_slot && position_x < distance_slot*2) {// Stage 1 : Two kinds of enemy will appear
				if (flag != 2) {
					randomNum=Random.Range (1, 4);
				}
				flag=2;

//				int position = position_x % (2 * stage_slot);
//				if (position > stage_slot) {// In the second stage, enemy occurs. (first stage edges occurs)


					if (randomNum == 1) {// No Up ghost
						CreateEnemyLeft ();
						CreateEnemyCannon ();
					}
					if (randomNum == 2) {// No Left ghost
						CreateEnemyUp ();
						CreateEnemyCannon ();
					}
					if (randomNum == 3) {// No Cannon
						CreateEnemyUp ();
						CreateEnemyLeft ();
					}
//				}


			}

			if (position_x > distance_slot*2 && position_x < distance_slot*3) {// Stage 3 : Three kinds of enemy will appear
				if (flag != 3) {
					randomNum=Random.Range (1, 4);
				}
				flag=3;

//				int position = position_x % (2 * stage_slot);
//				if (position > stage_slot) {// In the second stage, enemy occurs. (first stage edges occurs)
					
					
					CreateEnemyUp ();
					CreateEnemyLeft ();
					CreateEnemyCannon ();
//				}

			}

			last_position = transform.position.x;// update last appear position
		}
	}

	public void CreateEnemyUp(){
		int random=Random.Range (0, 2);
		if (random == 1) {
			Vector2 pos=new Vector3 (transform.position.x + 20f, 1.5f, transform.position.z);
			var clone_up = Instantiate (Ghost_up_prefab, pos, Quaternion.identity) as GameObject;
			print("ghostUp "+transform.position.x);
		}

		//var clone_left = Instantiate (Ghost_left_prefab, pos, Quaternion.identity) as GameObject;
		//clone.transform.localScale = transform.localScale;

	}
	public void CreateEnemyLeft(){
		//var clone_up = Instantiate (Ghost_up_prefab, pos, Quaternion.identity) as GameObject;
		for (int i = 0; i < 3; i++) {
			int random=Random.Range (0, 2);
			if (random == 1) {
				Vector2 pos=new Vector3 (transform.position.x + 20f, -3 + i * 3, transform.position.z);
				var clone_left = Instantiate (Ghost_left_prefab, pos, Quaternion.identity) as GameObject;
				print("ghostLeft "+transform.position.x);
			}
		}



		//clone.transform.localScale = transform.localScale;
	}
	public void CreateEnemyCannon(){
		int random=Random.Range (0, 2);
		if (random == 1) {
			Vector2 pos = new Vector3 (transform.position.x + 20f, -4f, transform.position.z);
			var cannon = Instantiate (Cannon_prefab, pos, Quaternion.identity) as GameObject;
			print("Cannon "+transform.position.x);
		}

	}
}
