using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
	private void Start()
	{
		lr = GetComponent<LineRenderer>();
		Show(false);
	}

	public void Show(bool show)
	{
		lr.enabled = show;
	}

	public void UpdatePositions(Vector3 start, Vector3 end)
	{
		lr.SetPosition(0, Camera.main.ScreenToWorldPoint(new Vector3(start.x, start.y, 10)));
		lr.SetPosition(1, Camera.main.ScreenToWorldPoint(new Vector3(end.x, end.y, 10)));
	}

	private LineRenderer lr;
}
