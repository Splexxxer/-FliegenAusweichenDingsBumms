using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class AnimatedBackAndDisplay : MonoBehaviour
{
    public string[] names;

    private Animator animator;
    public TextMeshProUGUI nameOfSkin;

    public int index;

    private void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
        applySkin();
    }

    public void OnpressedRight()
    {
        if (index != names.Length)
        {
            index++;
            applySkin();
        }
    }
    public void OnpressedLeft()
    {
        if (index != 0)
        {
            index--;
            applySkin();
        }
    }

    void applySkin()
    {       
        nameOfSkin.SetText(names[index]);
        animator.SetInteger("index",index);
    }
}

