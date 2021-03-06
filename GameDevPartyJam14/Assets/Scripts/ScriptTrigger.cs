﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTrigger : MonoBehaviour
{
	public List<float> Timers;
	void Start()
	{
		audioSource = GetComponent<AudioSource>();
		tm = GetComponent<TriggerManager>();
	}

	void Update()
	{
		timer += Time.deltaTime;
		if (nbr < Timers.Count && timer >= Timers[nbr])
		{
			Debug.Log("Coucou");
			tm.PlayEvent(nbr);
			++nbr;
		}
	}

	bool play = true;

	int nbr = 0;
	float timer = 0.0F;
	AudioSource audioSource;
	TriggerManager tm;
}
