using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float Speed = 100;
	public float JumpForce = 50;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		pi = GetComponent<PlayerInformations>();
		ps = GetComponent<PlayerSounds>();
		an = transform.Find("New Sprite").GetComponent<Animator>();
		sr = transform.Find("New Sprite").GetComponent<SpriteRenderer>();
		originalPosition = transform.position;
		Init();
    }

    void Init()
	{
		speed = 0;
		velocity = new Vector2();
		jumping = false;
		pi.Alive = true;
		pi.CanMove = false;
		transform.position = originalPosition;
	}

	void Update()
	{
		if (pi.Alive == false)
		{
			pi.DeathCounter -= Time.deltaTime;
			if (pi.DeathCounter <= 0.0f)
			{
				pi.DeathCounter = 3.0f;
				Init();
			}
			return;
		}


		if (pi.CanMove == false && Input.GetAxis("Submit") > 0.5f)
		{
			pi.CanMove = true;
		}
	}

	float t = 0.0f;

	private void FixedUpdate()
	{
		if (pi.Alive == false)
		{
			return;
		}

		if (pi.CanMove == false)
		{
			return;
		}

		float horizontalMovement = Input.GetAxis("Horizontal");


		if (horizontalMovement < -0.1f)
		{
			sr.flipX = true;
		}
		else if (horizontalMovement > 0.1f)
		{
			sr.flipX = false;
		}

		speed = Time.fixedDeltaTime * horizontalMovement * Speed;

		velocity.y = rb.velocity.y;

		if (Input.GetAxis("Jump") > 0.5f && jumping == false)
		{
			velocity.y = JumpForce;
			jumping = true;
			//ps.PlayOneShot(0); // JUMP
		}

		velocity.x = speed;

		rb.velocity = velocity;
		an.SetFloat("velocity", Mathf.Abs(horizontalMovement));
		an.SetBool("jumping", jumping);
		an.SetFloat("jumpVelocity", rb.velocity.y);
		t = horizontalMovement;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.collider.tag == "TopCollider")
		{
			jumping = false;
		}
		else if (collision.collider.tag == "Trap")
		{
			pi.Alive = false;
			pi.CanMove = false;
			//ps.PlayOneShot(0); // DEATH
		}
		else if (collision.collider.tag == "BottomCollider")
		{
			//ps.PlayOneShot(0); // TUD (Le perso se tappe la tête)
		}
	}

	private Rigidbody2D rb;
	private PlayerInformations pi;
	private PlayerSounds ps;

	private float speed = 0;
	private Vector2 velocity = new Vector2();
	private bool jumping = false;
	private Vector3 originalPosition;

	private Animator an;
	private SpriteRenderer sr;
}
