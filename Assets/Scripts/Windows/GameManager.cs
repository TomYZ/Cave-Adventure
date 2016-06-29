using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject playerPrefab;

	private GameObject player;



	// Use this for initialization
	void Start () {
		ResetGame ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void ResetGame(){
		player = GameObjectUtil.Instantiate (playerPrefab, 
			new Vector3 (-30, 0, 0));
	}
}
