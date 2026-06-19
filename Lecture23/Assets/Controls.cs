using System.Collections.Generic;
using UnityEngine;


public class Controls : MonoBehaviour
{
	public BoxCollider2D footCollider;
	
	public Rigidbody2D rigidBody;

	public int jumpForce;

	private bool jumped = false;



	void Update()
	{
		List<Collider2D> overlaps = new();
		footCollider.Overlap(overlaps);
		bool grounded = overlaps.Exists(c => c.gameObject.CompareTag("Ground"));
		if (!grounded) {
			jumped = false;
			return;
		}

		if (Input.GetButton("Jump") && !jumped) {
			rigidBody.AddForce(gameObject.transform.rotation * Vector2.up * jumpForce);
			jumped = true;
		}
	}
}
