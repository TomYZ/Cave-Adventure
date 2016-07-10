using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class challengeDistance : MonoBehaviour {

    // Use this for initialization
    private int challenge;
   
	public Text scoreEvent;
	private int dist = 0;
	private int temp = 0;
	void Start () {
        if (PlayerPrefs.HasKey("travel"))
        {
            PlayerPrefs.SetInt("travel", 100);
            PlayerPrefs.Save();
        }
		scoreEvent.text = "";
		challenge = PlayerPrefs.GetInt ("travel");
		print ("Challenege " + challenge);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
		 dist = (33 + (int)(transform.position.x));

        if (dist > challenge)
        {
			
			temp = dist;
            challenge = challenge + 100;
			scoreEvent.text = "New Challenge, reach " +challenge+ " feets";
            PlayerPrefs.SetInt("travel", challenge);
            PlayerPrefs.Save();
			//print ("temp"+ temp);
            
        }
		if (dist > (temp + 10)) {
			scoreEvent.text = "";
		}

	}

		

}
