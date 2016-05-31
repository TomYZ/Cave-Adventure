using UnityEngine;
using System.Collections;

public class BGControll : MonoBehaviour {

	private float mSpeed=2.0F;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		//Translate form right to left  
		transform.Translate(Vector3.left * Time.deltaTime * mSpeed);  
		// If first background is out of camera view,then show sencond background  
		if(transform.position.x<=-1.6F)  
		{  
			//We can change this value to reduce the wdith between 2 background  
			transform.position=new Vector3(13.6F,transform.position.y,transform.position.z);  
		}  
	}
}
