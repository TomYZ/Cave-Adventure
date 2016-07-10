using UnityEngine;
using System.Collections;
public class SoundManager3 : MonoBehaviour {
	public AudioClip ExplosionClip;
	AudioSource myAudio;
	public static SoundManager3 instance;
	void Awake()
	{
		if (SoundManager3.instance == null)
		{
			SoundManager3.instance = this;
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