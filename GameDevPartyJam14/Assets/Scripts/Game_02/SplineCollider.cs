using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PathCreator))]
[RequireComponent(typeof(EdgeCollider2D))]
public class SplineCollider : MonoBehaviour
{

	void Start()
	{
		pc = GetComponent<PathCreator>();
		p = pc.path;
		ec = GetComponent<EdgeCollider2D>();
		List<Vector2> points = new List<Vector2>();

		//for (int i = 0; i < 100; ++i)
		//{
		//	points.Add(s.GetLocationAlongSpline(i * (s.nodes.Count / 100.0f)));
		//}



		//float offset = 1 / 100.0F;
		//for (float f = 0; f < p.Points.Count; f += offset)
		//{
		//	//f = f > s.nodes.Count ? s.nodes.Count : f;
		//	points.Add(s.GetLocationAlongSpline(f));
		//}

		//ec.points = points.ToArray();
	}

	Path p;
	PathCreator pc;
	EdgeCollider2D ec;
}
