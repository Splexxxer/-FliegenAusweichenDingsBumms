using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
	public float speed = 10.0f;

	void Update()
	{
		float moveHorizontal= Input.GetAxis("HorizontalPlayer1");
		float moveVertical = Input.GetAxis("VerticalPlayer1");

		Vector2 movment = new Vector2(moveHorizontal, moveVertical);
		
		GetComponent<Rigidbody2D>().velocity = (movment * speed);		       
	}
}
