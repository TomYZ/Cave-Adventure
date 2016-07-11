using UnityEngine;
using System.Collections;
public class SoundManager6 : MonoBehaviour {
	public AudioClip ExplosionClip;
	AudioSource myAudio;
	public static SoundManager6 instance;
	void Awake()
	{
		if (SoundManager6.instance == null)
		{
			SoundManager6.instance = this;
		}          
	}
	void Start()
	{
		myAudio = GetComponent<AudioSource>();
	}
	public void PlaySound()
	{
		myAudio.PlayOneShot(ExplosionClip);
	}

	void Update(){

	}
}