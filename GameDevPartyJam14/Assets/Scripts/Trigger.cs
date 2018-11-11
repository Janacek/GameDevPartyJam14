using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
	public int EventNumber;

	void Start()
	{
		tm = GameObject.Find("TriggerManager").GetComponent<TriggerManager>();
	}

	void Update()
	{

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		tm.PlayEvent(EventNumber);
		EventNumber = -1;
	}

	TriggerManager tm;
}
