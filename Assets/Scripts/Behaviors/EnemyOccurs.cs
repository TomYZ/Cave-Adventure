using UnityEngine;
using System.Collections;

public class EnemyOccurs : MonoBehaviour {

	private float last_position,enemy_delay=10f,randomNum;
	public GameObject Ghost_up_prefab,Ghost_left_prefab,Cannon_prefab;

	// Use this for initialization
	void Start () {
		last_position = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
		

		if (transform.position.x - last_position > enemy_delay) {
			
			randomNum=Random.Range (0, 2);
			if (randomNum == 1) {
				for (int i = 0; i < 3; i++) {
					randomNum = Random.Range (0, 2);
					if (randomNum == 1) {
						CreateEnemyLeft (new Vector3 (transform.position.x + 20f, -3 + i * 3, transform.position.z));

					}

				}
			}


		}
		if (transform.position.x - last_position > enemy_delay) {
			
			randomNum=Random.Range (0, 2);
			if (randomNum == 1) {
				
				CreateEnemyUp (new Vector3 (transform.position.x + 20f, 1.5f, transform.position.z));
			}

		}
		if (transform.position.x - last_position > enemy_delay) {
			last_position = transform.position.x;
			randomNum=Random.Range (0f, 1f);
			if (randomNum <= 1) {

				CreateEnemyCannon (new Vector3 (transform.position.x + 20f, -4f, transform.position.z));
			}

		}


	}

	public void CreateEnemyUp(Vector2 pos){
		var clone_up = Instantiate (Ghost_up_prefab, pos, Quaternion.identity) as GameObject;
		//var clone_left = Instantiate (Ghost_left_prefab, pos, Quaternion.identity) as GameObject;
		//clone.transform.localScale = transform.localScale;

	}
	public void CreateEnemyLeft(Vector2 pos){
		//var clone_up = Instantiate (Ghost_up_prefab, pos, Quaternion.identity) as GameObject;
		var clone_left = Instantiate (Ghost_left_prefab, pos, Quaternion.identity) as GameObject;

		//clone.transform.localScale = transform.localScale;
	}
	public void CreateEnemyCannon(Vector2 pos){
		var cannon = Instantiate (Cannon_prefab, pos, Quaternion.identity) as GameObject;
	}
}
