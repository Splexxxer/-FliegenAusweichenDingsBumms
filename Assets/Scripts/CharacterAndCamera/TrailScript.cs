using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailScript : MonoBehaviour
{
	public Animator animator;
    void Update()
    {
		if (Input.GetAxis("HorizontalPlayer1") > 0)
		{
			animator.SetBool("AnimationStateForward", true);
		}
		else
		{
			animator.SetBool("AnimationStateForward", false);
		}
	}
}
