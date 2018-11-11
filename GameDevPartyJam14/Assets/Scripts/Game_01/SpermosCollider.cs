using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpermosCollider : MonoBehaviour
{
	public LangueController lc;

	void Start()
	{
		
	}

	void Update()
	{

	}

	private void OnTriggerEnter(Collider other)
	{
		lc.PlayerCollided();
	}

}
