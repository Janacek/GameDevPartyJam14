using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpriteManager : MonoBehaviour
{

	public List<GameObject> Sprites;
	public string SceneToLoad;
	
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (pressed == false && Input.GetAxis("Jump") > 0.5f)
		{
			if (nbr < Sprites.Count)
			{
				Sprites[nbr].SetActive(true);
			}
			else
			{
				SceneManager.LoadScene(SceneToLoad);
			}
			++nbr;
			pressed = true;
		}
		if (Input.GetAxis("Jump") < 0.5f)
		{
			pressed = false;
		}
	}

	bool pressed = false;
	int nbr = 0;
}
