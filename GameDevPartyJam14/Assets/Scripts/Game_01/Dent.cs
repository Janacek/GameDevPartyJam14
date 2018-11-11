using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dent : MonoBehaviour
{
	public float Speed = 15;

	void Start()
	{
	}

	void Update()
	{
		transform.Rotate(-Speed * Time.fixedDeltaTime, 0, 0);
		timer -= Time.deltaTime;
		if (timer <= 0.0f)
		{
			GameObject.Destroy(this.gameObject);
		}
	}

	float timer = 5.0f;
}
