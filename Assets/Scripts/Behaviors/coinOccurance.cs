using UnityEngine;
using System.Collections;

public class coinOccurance : MonoBehaviour {

	private float start_time;
	public GameObject CoinPrefab;
	private float interval = 0f;

	// Use this for initialization
	void Start()
	{
		start_time = Time.time;
	}

	// Update is called once per frame
	void Update()
	{
		if (Time.time - start_time > interval)
		{
			interval = Random.Range (0f, 1f) * 20f;
			start_time = Time.time;
			float y = Random.Range(-3.0f, 3.0f);
			float shift = .5f;
			for (int i = 0; i < Random.Range(5, 10); i++)
			{
				if (Mathf.Approximately(y, 3.0f) || y > 3.0f)
				{
					shift = -0.5f;
				}
				else if (Mathf.Approximately(y, -3.0f) || y < -3.0f)
				{
					shift = 0.5f;
				}
				y = y + shift;
				print(y + " shift: " + shift);
				CreateCoins(new Vector3(transform.position.x + i + 15f, y, transform.position.z));

			}
		}
	}

	public void CreateCoins(Vector2 pos)
	{
		var clone = Instantiate(CoinPrefab, pos, Quaternion.identity) as GameObject;
		//clone.transform.localScale = transform.localScale;
	}

}
