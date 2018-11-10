using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OeufController : MonoBehaviour
{

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		oi = GetComponent<OeufInformations>();
		lc = GameObject.Find("Line").GetComponent<LineController>();
	}

	void Update()
	{
		if (oi.CanThrow)
		{
			if (Input.GetMouseButtonDown(0))
			{
				m_first = Input.mousePosition;
				lc.Show(true);
			}
			else if (Input.GetMouseButtonUp(0))
			{
				m_last = Input.mousePosition;

				Vector3 directorVector = m_first - m_last;
				//rb.AddForce(new Vector2(directorVector.x, 0));
				Debug.Log(directorVector);
				rb.velocity = new Vector2(directorVector.x / 20, rb.velocity.y);
				lc.Show(false);
			}
			if (Input.GetMouseButton(0))
			{
				lc.UpdatePositions(m_first, Input.mousePosition);
			}

			Vector2 vel = new Vector2(Time.deltaTime * 1 * rb.velocity.x > 0 ? -1 : 1, 0);



			rb.velocity += vel;
			if (Mathf.Abs(rb.velocity.x) <= 1f)
			{
				rb.velocity = new Vector2(0, rb.velocity.y);
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Trigger")
		{
			oi.CanThrow = !oi.CanThrow;
		}
	}

	private void FixedUpdate()
	{
		Vector3 pos = transform.position;
		pos.z = Camera.main.transform.position.z;


		Camera.main.transform.position = pos;
	}

	Rigidbody2D rb;
	OeufInformations oi;
	LineController lc;

	private Vector3 m_first = new Vector3();
	private Vector3 m_last = new Vector3();
}
