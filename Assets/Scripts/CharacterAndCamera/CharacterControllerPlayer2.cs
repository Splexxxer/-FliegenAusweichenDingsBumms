using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerPlayer2 : MonoBehaviour
{
	public float speed = 10.0f;
	public Animator animator;

	void Update()
	{
		float moveHorizontal = Input.GetAxis("HorizontalPlayer2");
		float moveVertical = Input.GetAxis("VerticalPlayer2");

		Vector2 movment = new Vector2(moveHorizontal, moveVertical);

		GetComponent<Rigidbody2D>().velocity = (movment * speed);

		if (Input.GetAxis("HorizontalPlayer2") > 0)
		{
			animator.SetBool("AnimationStateForward", true);
		}
		else
		{
			animator.SetBool("AnimationStateForward", false);
		}
		if (Input.GetAxis("HorizontalPlayer2") < 0)
		{
			animator.SetBool("AnimationStateBackward", true);
		}
		else
		{
			animator.SetBool("AnimationStateBackward", false);
		}
	}
}
