using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class challengeDistance : MonoBehaviour {

	public Text scoreEvent;

	private int dist = 0;
	private int temp = 0;
	private int challenge;

	void Start () {
        if (PlayerPrefs.HasKey("travel"))
        {
            PlayerPrefs.SetInt("travel", 100);
            PlayerPrefs.Save();
        }
		scoreEvent.text = "";
		challenge = PlayerPrefs.GetInt ("travel");
		scoreEvent.text = "New Challenge, reach " +challenge+ " feets";
		temp = 10;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
		 dist = (33 + (int)(transform.position.x));

        if (dist > challenge)
        {
			temp = dist;
			gameObject.GetComponent<MainController> ().updateCoin(challenge/10,challenge/10);
			//gameObject.GetComponent<MainController> ().coinText.text = gameObject.GetComponent<MainController> ().coinCou.ToString();

			challenge = challenge + 100;
			scoreEvent.text = "New Challenge, reach " +challenge+ " feets";
			PlayerPrefs.SetInt("travel", challenge);
			PlayerPrefs.Save();

			//print ("temp"+ temp);   
        }

		if (dist > (temp + 15)) {
			scoreEvent.text = "";
		}

	}
}
