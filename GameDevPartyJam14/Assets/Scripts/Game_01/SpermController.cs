using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpermController : MonoBehaviour
{
	public float Speed;

	public DentManager dm;
	public LangueController lc;

	void Start()
	{

	}

	void FixedUpdate()
	{
		float rotation = Input.GetAxis("Horizontal");

		totalRotation += rotation;
		if (totalRotation > 20.0f)
		{
			totalRotation = 20.0f;
		}
		else if (totalRotation < -20)
		{
			totalRotation = -20.0f;
		}
		else
		{
			transform.Rotate(0, 0, rotation * Time.fixedDeltaTime * Speed * -1);
		}
	}

	float totalRotation = 0.0f;
}
