using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailScriptPlayer2 : MonoBehaviour
{
	public Animator animator;
	void Update()
	{
		if (Input.GetAxis("HorizontalPlayer2") > 0)
		{
			animator.SetBool("AnimationStateForward", true);
		}
		else
		{
			animator.SetBool("AnimationStateForward", false);
		}
	}
}
