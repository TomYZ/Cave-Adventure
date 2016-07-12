using UnityEngine;
using System.Collections;
public class SoundManager10 : MonoBehaviour {
	public AudioClip ExplosionClip;
	AudioSource myAudio;
	public static SoundManager10 instance;
	void Awake()
	{
		if (SoundManager10.instance == null)
		{
			SoundManager10.instance = this;
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