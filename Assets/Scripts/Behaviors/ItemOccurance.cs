using UnityEngine;
using System.Collections;

public class ItemOccurance : MonoBehaviour {

	private float start_time_heart;
	private float start_time_boost;
	public GameObject heart;
	public GameObject boost;

	// Use this for initialization
	void Start()
	{
		start_time_heart = Time.time;
		start_time_boost = Time.time;
	}

	// Update is called once per frame
	void Update()
	{
		if (Time.time - start_time_heart > 17f)
		{
			start_time_heart = Time.time;
			Createheart(new Vector3(transform.position.x + 15f, 0, transform.position.z));
		}
		if (Time.time - start_time_boost > 33f)
		{
			start_time_boost = Time.time;
			CreateBoost(new Vector3(transform.position.x + 17f, 0, transform.position.z));
		}
	}

	public void Createheart(Vector2 pos)
	{
		var clone1 = Instantiate(heart, pos, Quaternion.identity) as GameObject;
		//clone.transform.localScale = transform.localScale;
	}

	public void CreateBoost(Vector2 pos)
	{
		var clone2 = Instantiate(boost, pos, Quaternion.identity) as GameObject;
		//clone.transform.localScale = transform.localScale;
	}
}
