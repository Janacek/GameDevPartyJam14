using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeSpermosManager : MonoBehaviour
{
	public GameObject FakeSpermos;

	void Start()
	{

	}

	void Update()
	{
		timer -= Time.deltaTime;

		if (timer <= 0.0f)
		{
			timer = 1.0f;
			GameObject fakeSpermos = GameObject.Instantiate(FakeSpermos);
			fakeSpermos.transform.Rotate(0, 0, Random.Range(-20.0f, 20.0f));
			Debug.Log(fakeSpermos.transform.rotation);
		}
	}

	float timer = 1.0f;
}
