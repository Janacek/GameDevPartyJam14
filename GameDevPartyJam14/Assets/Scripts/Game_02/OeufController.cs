using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OeufController : MonoBehaviour
{

	public GameObject Entree;
	public GameObject Sortie;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		oi = GetComponent<OeufInformations>();
		lc = GameObject.Find("Line").GetComponent<LineController>();
	}

	float t = 0.0F;

	void Update()
	{
		if (endTimer > 0.0f)
		{
			endTimer -= Time.deltaTime;
		}
		if (endTimer < 0.0f)
		{
			GetComponent<CircleCollider2D>().enabled = false;
			Sortie.SetActive(true);
		}

		if (t > 0.0f)
		{
			t -= Time.deltaTime;
			if (t < 0.0f)
			{
				SceneManager.LoadScene("Transition_2_3");

			}
		}

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
				rb.velocity = new Vector2(directorVector.x / 10, rb.velocity.y);
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
		if (endTimer >= 0.0f)
		{
			Vector3 pos = transform.position;
			pos.z = Camera.main.transform.position.z;


			Camera.main.transform.position = pos;
		}
	}

	public void End()
	{
		oi.CanThrow = false;
		endTimer = 3.0f;
		Entree.SetActive(true);
		t = 4.5f;
	}

	Rigidbody2D rb;
	OeufInformations oi;
	LineController lc;

	float endTimer = 0.0f;

	private Vector3 m_first = new Vector3();
	private Vector3 m_last = new Vector3();
}
