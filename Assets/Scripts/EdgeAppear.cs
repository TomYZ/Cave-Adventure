using UnityEngine;
using System.Collections;
using System;

public class EdgeAppear : MonoBehaviour {

	private float last_position;
	public GameObject Edge1;
	public GameObject Edge2;
	public GameObject Edge3;
	public GameObject Edge4;
	public int iUp;
	private float camerasize;

	// Use this for initialization
	void Start () {
		last_position = transform.position.x;
		camerasize = Camera.main.orthographicSize;
		iUp=4;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x - last_position > 20) {
			last_position = transform.position.x;
			System.Random ro = new System.Random(); 
			int iResult;
			iResult = ro.Next (iUp);

			switch (iResult) {
			case 0:
				CreateProjectile (Edge1, new Vector3 (transform.position.x + 20f, transform.position.y + camerasize/2, transform.position.z));
				break;
			case 1:
				CreateProjectile (Edge2, new Vector3 (transform.position.x + 20f, transform.position.y - camerasize/2, transform.position.z));
				break;
			case 2:
				CreateProjectile (Edge3, new Vector3 (transform.position.x + 20f, transform.position.y + camerasize/2, transform.position.z));
				break;
			case 3:
				CreateProjectile (Edge4, new Vector3 (transform.position.x + 20f, transform.position.y - camerasize/2, transform.position.z));
				break;

			}
		}
	}

	public void CreateProjectile(GameObject Edge, Vector2 pos){
		var clone = Instantiate (Edge, pos, Quaternion.identity) as GameObject;
		//clone.transform.localScale = transform.localScale;
	}
}