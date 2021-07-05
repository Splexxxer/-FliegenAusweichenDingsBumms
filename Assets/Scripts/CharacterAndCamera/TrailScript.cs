using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailScript : MonoBehaviour
{
	public Animator animator;

	public CharacterController player;


	void Update()
    {
		
		if (player.movingForward)
		{
			animator.SetBool("AnimationStateForward", true);
		}
		else
		{
			animator.SetBool("AnimationStateForward", false);
		}
	}
}
