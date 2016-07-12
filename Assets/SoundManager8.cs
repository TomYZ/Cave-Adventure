using UnityEngine;
using System.Collections;
public class SoundManager8 : MonoBehaviour {
	public AudioClip ExplosionClip;
	AudioSource myAudio;
	public static SoundManager8 instance;
	void Awake()
	{
		if (SoundManager8.instance == null)
		{
			SoundManager8.instance = this;
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