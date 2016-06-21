using UnityEngine;
using System.Collections;

public class playmovie : MonoBehaviour {
	private string movPath = "3.mp4";

	// Use this for initialization
	void Start () {
		StartCoroutine(PlayStreamingVideo(movPath));
	}

	private IEnumerator PlayStreamingVideo(string url)
	{
		Handheld.PlayFullScreenMovie(url, Color.black, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.AspectFill);
		yield return new WaitForEndOfFrame();
		yield return new WaitForEndOfFrame();
		Debug.Log("Video playback completed.");
	}
}