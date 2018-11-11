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
		timer -= Time.deltaTime;
		if (timer <= 0.0f)
		{
			transform.Rotate(-Speed * Time.fixedDeltaTime, 0, 0);
		}
		else
		{
			transform.Rotate(Speed * Time.fixedDeltaTime, 0, 0);
		}
	}

	public void PlayerCollided()
	{
		timer = 0.5f;
	}

	float timer = 0.0f;
}
