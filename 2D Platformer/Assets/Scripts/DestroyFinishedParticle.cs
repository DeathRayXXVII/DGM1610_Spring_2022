using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFinishedParticle : MonoBehaviour {

	private ParticleSystem thisPatricleSystem;

	// Use this for initialization
	void Start () 
	{
		thisPatricleSystem = GetComponent<ParticleSystem>();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(thisPatricleSystem.isPlaying)
			return;

		Destroy (gameObject);
	}
	void OnBecomeInvisible ()
	{
		Destroy (gameObject);
	}
}
