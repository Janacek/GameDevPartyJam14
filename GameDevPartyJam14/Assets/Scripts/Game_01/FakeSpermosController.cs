using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeSpermosController : MonoBehaviour
{

	void Start()
	{

	}

	void Update()
	{

	}

	private void FixedUpdate()
	{
		timer -= Time.fixedDeltaTime;
		gtimer -= Time.fixedDeltaTime;

		if (timer > 0.0f)
		{
			transform.Rotate(5 * Time.fixedDeltaTime, 0, 0);
		}
		else
		{
			transform.Rotate(-5 * Time.fixedDeltaTime, 0, 0);
		}

		if (gtimer <= 0.0f)
		{
			Destroy(this.gameObject);
		}
	}

	float timer = 3.5f;
	float gtimer = 7.0f;
}
