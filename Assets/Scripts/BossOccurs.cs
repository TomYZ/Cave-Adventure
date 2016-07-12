using UnityEngine;
using System.Collections;

public class BossOccurs : MonoBehaviour {
	public float whereBossOccurs;
	public GameObject boss;
	private bool IsBossOccurs;
	// Use this for initialization
	void Start () {
		IsBossOccurs = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!IsBossOccurs && transform.position.x > whereBossOccurs) {
			CreateBoss (new Vector2(transform.position.x+30, transform.position.y));
			IsBossOccurs = true;
		}
	}

	public void CreateBoss(Vector2 pos)
	{
		var clone = Instantiate(boss, pos, Quaternion.identity) as GameObject;

		//clone.transform.localScale = transform.localScale;
	}
}
