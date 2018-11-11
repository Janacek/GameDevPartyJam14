using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OvuleController : MonoBehaviour
{

	public float Timer = 90.0f;

	void Start()
	{
		t = Timer;
		m = transform.rotation.x;
	}

	void Update()
	{
		t -= Time.deltaTime;
	}

	private void FixedUpdate()
	{
		// END GAME
		if (t <= 0.0f)
		{
			SceneManager.LoadScene("Game_02");
		}
	}

	float m;

	float t;
}
