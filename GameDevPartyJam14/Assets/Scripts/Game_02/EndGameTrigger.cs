﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameTrigger : MonoBehaviour
{

	void Start()
	{

	}

	void Update()
	{

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		collision.gameObject.GetComponent<OeufController>().End();
	}
}
