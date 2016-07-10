using UnityEngine;
using System.Collections;

public class InGameWindow : GenericWindow {
	public GameObject ingameMenu;

	public void GameOver(){
		manager.Open (2);
	}

	public void onPause(){
		Time.timeScale = 0;
		ingameMenu.SetActive (true);
	}

	public void onResume(){
		Time.timeScale = 1f;
		ingameMenu.SetActive (false);
	}

	public void onRestart(){
		Application.LoadLevel (0);
		Time.timeScale = 1f;
	}
}
