using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
	public float speed = 10.0f;
	public Animator animator;

	void Update()
	{
		float moveHorizontal= Input.GetAxis("HorizontalPlayer1");
		float moveVertical = Input.GetAxis("VerticalPlayer1");

		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		
		GetComponent<Rigidbody2D>().velocity = (movement * speed);
		
		if(Input.GetAxis("HorizontalPlayer1") > 0)
        {
			animator.SetBool("AnimationStateForward", true);
		}
        else
        {
			animator.SetBool("AnimationStateForward", false);
		}
		if (Input.GetAxis("HorizontalPlayer1") < 0)
		{
			animator.SetBool("AnimationStateBackward", true);
		}
        else
        {
			animator.SetBool("AnimationStateBackward", false);
		}
	}
}
