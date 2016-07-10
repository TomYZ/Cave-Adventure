using UnityEngine;
using System.Collections;
public class SoundManager5 : MonoBehaviour {
	public AudioClip ExplosionClip;
	AudioSource myAudio;
	public static SoundManager5 instance;
	void Awake()
	{
		if (SoundManager5.instance == null)
		{
			SoundManager5.instance = this;
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