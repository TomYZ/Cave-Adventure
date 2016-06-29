using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameoverWindow : GenericWindow {

	public void OnNext(){
		int scene = SceneManager.GetActiveScene ().buildIndex;
		SceneManager.LoadScene (scene, LoadSceneMode.Single);
	}
}
