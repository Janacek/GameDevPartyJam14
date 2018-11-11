using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TriggerManager : MonoBehaviour
{
	public List<AudioClip> clips;
	public List<string> texts;
	public List<float> times;

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
		sousTitres = GameObject.Find("SousTitres").transform.Find("Canvas").Find("SousTitreText").GetComponent<TextMeshProUGUI>();
		sousTitres.enabled = false;
	}

	void Update()
	{
		if (timer > 0.0f)
		{
			timer -= Time.deltaTime;
		}
		else
		{
			sousTitres.enabled = false;
		}
	}

	public void PlayEvent(int number)
	{
		if (number != -1)
		{
			audioSource.PlayOneShot(clips[number]);
			sousTitres.text = texts[number];
			timer = times[number];
			sousTitres.enabled = true;
		}
	}

	float timer;

	TextMeshProUGUI sousTitres;
	AudioSource audioSource;
}
