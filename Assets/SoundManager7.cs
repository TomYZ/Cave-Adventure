using UnityEngine;
using System.Collections;
public class SoundManager7 : MonoBehaviour {
	public AudioClip ExplosionClip;
	AudioSource myAudio;
	public static SoundManager7 instance;
	void Awake()
	{
		if (SoundManager7.instance == null)
		{
			SoundManager7.instance = this;
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