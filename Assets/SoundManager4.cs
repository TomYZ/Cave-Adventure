using UnityEngine;
using System.Collections;
public class SoundManager4 : MonoBehaviour {
	public AudioClip ExplosionClip;
	AudioSource myAudio;
	public static SoundManager4 instance;
	void Awake()
	{
		if (SoundManager4.instance == null)
		{
			SoundManager4.instance = this;
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