using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
	public PlayerControls controls;

	public float speed = 10.0f;
	public Animator animator;

	Vector2 move = Vector2.zero;

	public bool movingForward = false;

	private PlayerConfiguration playerConfig;
	private PlayerControls PlayerControls;

	public SpriteRenderer spriteRenderer;
	public Animator trailAnimator;

	private void Awake()
    {
		controls = new PlayerControls();
    }

	public void InitializePlayer(PlayerConfiguration pc)
    {
		playerConfig = pc;
		spriteRenderer.sprite = pc.PlayerSprite;
		trailAnimator.SetInteger("index", pc.animationState);
		Debug.Log(pc.animationState);

        playerConfig.Input.onActionTriggered += Input_onActionTriggered;		
	}

    private void Input_onActionTriggered(InputAction.CallbackContext obj)
    {
		if(obj.action.name == controls.Player.Movement.name)
        {
			OnMove(obj);
        }

	}

    public void OnMove(InputAction.CallbackContext context)
    {
		move = context.action.ReadValue<Vector2>();
    }

    void FixedUpdate()
	{
		Vector2 m = new Vector2(move.x, move.y) * Time.deltaTime * speed;
		
		transform.Translate(m, Space.World);

		
		if(m.x > 0)
        {
			animator.SetBool("AnimationStateForward", true);
			movingForward = true;
		}
        else
        {
			animator.SetBool("AnimationStateForward", false);
			movingForward = false;
		}
		if (m.x < 0)
		{
			animator.SetBool("AnimationStateBackward", true);
		}
        else
        {
			animator.SetBool("AnimationStateBackward", false);
		}
	}
}
