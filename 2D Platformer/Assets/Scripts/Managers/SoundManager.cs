using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour 
{
	public AudioSource efxSouce;
	public AudioSource musicSource;
	public static SoundManager instance = null;

	public float lowPitchRange = .95f;
	public float highPitchRange = 1.05f;

	// Use this for initialization
	void Awake () 
	{
		if(instance ==null)
			instance = this;
		else if (instance != null)
			Destroy (gameObject);
	
	}

	public void PlaySingle (AudioClip clip)
	{
		efxSouce.clip = clip;
		efxSouce.Play();
	}
	public void RandomizeSfx (params AudioClip [] clips)
	{
		int randomIndex = Random.Range(0, clips.Length);
		float randomPitch = Random.Range (lowPitchRange, highPitchRange);
		efxSouce.pitch = randomPitch;
		efxSouce.clip = clips[randomIndex];
		efxSouce.Play();
	}
}
