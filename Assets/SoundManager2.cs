using UnityEngine;
using System.Collections;
public class SoundManager2 : MonoBehaviour {
	public AudioClip ExplosionClip;
	AudioSource myAudio;
	public static SoundManager2 instance;
	void Awake()
	{
		if (SoundManager2.instance == null)
		{
			SoundManager2.instance = this;
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