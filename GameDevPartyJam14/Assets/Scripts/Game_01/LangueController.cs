using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LangueController : MonoBehaviour
{
	public float Speed = 10;

	void Start()
	{

	}

	void Update()
	{

	}

	private void FixedUpdate()
	{
		transform.Rotate(-Speed * Time.fixedDeltaTime, 0, 0);
	}

}
