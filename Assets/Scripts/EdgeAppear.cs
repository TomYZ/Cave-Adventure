using UnityEngine;
using System.Collections;
using System;

public class EdgeAppear : MonoBehaviour {

	private float last_position;
	private float Edge_begin_position;
	private GameObject Edge1;
	private GameObject Edge2;
	private GameObject Edge3;
	private GameObject Edge4;
	public GameObject Stage1Edge1;
	public GameObject Stage1Edge2;
	public GameObject Stage1Edge3;
	public GameObject Stage1Edge4;
	public GameObject Stage2Edge1;
	public GameObject Stage2Edge2;
	public GameObject Stage2Edge3;
	public GameObject Stage2Edge4;
	public float wherestarStage2;
	public int iUp;
	public float edgeArea_appear_distance;
	public float edge_appear_distance;
	private float camerasize;


	// Use this for initialization
	void Start () {
		last_position = -100f;
		Edge_begin_position = transform.position.x;
		camerasize = Camera.main.orthographicSize;
		Edge1 = Stage1Edge1;
		Edge2 = Stage1Edge2;
		Edge3 = Stage1Edge3;
		Edge4 = Stage1Edge4;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x > wherestarStage2) {
			Edge1 = Stage2Edge1;
			Edge2 = Stage2Edge2;
			Edge3 = Stage2Edge3;
			Edge4 = Stage2Edge4;

		}
		if (transform.position.x - last_position > edgeArea_appear_distance) {
			last_position = transform.position.x;
			print(transform.position.x);
			System.Random ro = new System.Random(); 
			for(int i=0;i<iUp;i++)
			{
				float position = transform.position.x + 20f + i*edge_appear_distance;
				int iResult;
				iResult = ro.Next (iUp);
				switch (iResult) {
				case 0:
					CreateProjectile (Edge1, new Vector3 (position, transform.position.y + camerasize / 2, transform.position.z));
					break;
				case 1:
					CreateProjectile (Edge2, new Vector3 (position, transform.position.y - camerasize / 2, transform.position.z));
					break;
				case 2:
					CreateProjectile (Edge3, new Vector3 (position, transform.position.y + camerasize / 2, transform.position.z));
					break;
				case 3:
					CreateProjectile (Edge4, new Vector3 (position, transform.position.y - camerasize / 2, transform.position.z));
					break;
				}
			}
		}
	}

	public void CreateProjectile(GameObject Edge, Vector2 pos){
		var clone = Instantiate (Edge, pos, Quaternion.identity) as GameObject;
		//clone.transform.localScale = transform.localScale;
	}
}