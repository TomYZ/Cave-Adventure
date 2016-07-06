using UnityEngine;
using System.Collections;

public class BGControll : MonoBehaviour {
	public Texture texture;
	public float wherestarStage2;
	private float mSpeed=0.6F;
	public GameObject target;
	private Transform _t;
	private float threshold = 72.0f;
	private float translate = 0;
	private float last_position = -35.3f; //target's last postion
	private float last_frame_position = -35.3f; //target's last postion
	private float diffbetweencharandbf;
	// Use this for initialization
	void Start () {
		_t = target.transform;
		last_position = _t.position.x;
		last_frame_position = _t.position.x;
		diffbetweencharandbf = transform.position.x - _t.position.x;
	}


	// Update is called once per frame
	void Update () {
		//Translate form right to left
		translate+= (_t.position.x-last_frame_position) * mSpeed;
		transform.Translate(Vector3.right * (_t.position.x-last_frame_position) * mSpeed);
		last_frame_position = _t.position.x;
		// If first background is out of camera view,then show sencond background  
		if (_t.position.x > threshold+last_position+translate) {
			transform.position = new Vector3 (_t.position.x + diffbetweencharandbf, 0, transform.position.z);
			last_position = _t.position.x;
			translate = 0;
		}
		if(transform.position.x> wherestarStage2)
		{
			GetComponent<Renderer>().material.mainTexture = texture;
			threshold = 50f;
		}
	}
}
