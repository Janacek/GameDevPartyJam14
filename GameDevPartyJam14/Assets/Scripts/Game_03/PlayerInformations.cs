using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformations : MonoBehaviour
{
	public bool Alive
	{
		get
		{
			return alive;
		}
		set
		{
			alive = value;
		}
	}

	public bool CanMove
	{
		get
		{
			return canMove;
		}
		set
		{
			canMove = value;
		}
	}

	public float DeathCounter
	{
		get
		{
			return deathCounter;
		}
		set
		{
			deathCounter = value;
		}
	}

	private bool alive = true;
	private bool canMove = false;
	private float deathCounter = 3.0f;
}
