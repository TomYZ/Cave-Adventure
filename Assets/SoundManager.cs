using UnityEngine;
using System.Collections;
public class SoundManager : MonoBehaviour {
	public AudioClip ExplosionClip;
	AudioSource ExplosionSource;
	public static SoundManager soundManager;
	void Awake()
	{
		if (SoundManager.soundManager == null)
		{
			SoundManager.soundManager = this;
		}          
	}
	void Start()
	{
		ExplosionSource = GetComponent<AudioSource>();
	}
	public void PlaySound()
	{
		ExplosionSource.PlayOneShot(ExplosionClip);
	}
}