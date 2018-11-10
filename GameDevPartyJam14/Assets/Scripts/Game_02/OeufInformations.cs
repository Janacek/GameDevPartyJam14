using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OeufInformations : MonoBehaviour
{
	public bool CanThrow
	{
		get
		{
			return canThrow;
		}
		set
		{
			canThrow = value;
		}
	}

	private bool canThrow = true;
}
