using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayerSounds : MonoBehaviour
{
	public List<AudioClip> Clips;

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	public void PlayOneShot(int number)
	{
		audioSource.PlayOneShot(Clips[number]);
	}

	private AudioSource audioSource;
}
