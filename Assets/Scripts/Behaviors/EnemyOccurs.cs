using UnityEngine;
using System.Collections;

public class EnemyOccurs : MonoBehaviour {

	private float start_time_left,start_time_up;
	public GameObject Ghost_up_prefab,Ghost_left_prefab;

	// Use this for initialization
	void Start () {
		start_time_left = Time.time;
		start_time_up = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		float y = Random.Range(3f, 7f);
		if (Time.time - start_time_left > y) {
			start_time_left = Time.time;
			CreateEnemyLeft(new Vector3 (transform.position.x + 20f,0, transform.position.z));

		}
		y = Random.Range(3f, 7f);
		if (Time.time - start_time_up > y) {
			start_time_up = Time.time;
			CreateEnemyUp(new Vector3 (transform.position.x + 20f,1.5f, transform.position.z));

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
}
