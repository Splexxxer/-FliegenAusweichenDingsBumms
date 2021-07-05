using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class DisplaySpriteInMenu : MonoBehaviour
{
    public List<Sprite> sprites;

    private Image skin;
    public TextMeshProUGUI nameOfSkin;

    public int index;

    private void Awake()
    {
        skin = gameObject.GetComponent<Image>();
        applySkin();
    }

    public void OnpressedRight()
    {
        if(index != sprites.Count)
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
        skin.sprite = sprites[index];
        nameOfSkin.SetText(sprites[index].name);
    }
}
