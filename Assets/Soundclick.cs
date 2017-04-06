using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Soundclick : MonoBehaviour {
	public AudioSource source;
	public AudioClip Click;
	public bool Audion = true;

	public void Turnoff ()
	{
		Audion = false;
	}
	public void Turnon()
	{
		Audion = true;
	}

	public void Onclick ()
	{
		if (Audion == true)
		{
			source.PlayOneShot (Click);
		}
	}
}
