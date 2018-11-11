using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

	public int Speed;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void FixedUpdate()
	{
		transform.Rotate(0, 0, Time.fixedDeltaTime * Speed);
	}
}
