using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerPlayer2 : MonoBehaviour
{
	public float speed = 10.0f;

	void Update()
	{
		float moveHorizontal = Input.GetAxis("HorizontalPlayer2");
		float moveVertical = Input.GetAxis("VerticalPlayer2");

		Vector2 movment = new Vector2(moveHorizontal, moveVertical);

		GetComponent<Rigidbody2D>().velocity = (movment * speed);
	}
}
