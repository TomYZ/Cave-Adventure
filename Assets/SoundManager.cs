using UnityEngine;
using System.Collections;
public class SoundManager : MonoBehaviour {
	public AudioClip ExplosionClip;
	AudioSource myAudio;
	public static SoundManager instance;
	void Awake()
	{
		if (SoundManager.instance == null)
		{
			SoundManager.instance = this;
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