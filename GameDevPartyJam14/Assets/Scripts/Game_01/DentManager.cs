using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DentManager : MonoBehaviour
{
	public GameObject Dent;

	void Start()
	{
		dents = new List<GameObject>();
		timer = 5.0f;
	}

	void Update()
	{
		timer -= Time.deltaTime;

		if (timer <= 0.0f)
		{
			timer = 5.0f;
			GameObject dent = GameObject.Instantiate(Dent);
			dent.transform.Rotate(0, 0, Random.Range(-20.0f, 20.0f));
		}
	}

	float timer = 0.0f;

	List<GameObject> dents;
}
