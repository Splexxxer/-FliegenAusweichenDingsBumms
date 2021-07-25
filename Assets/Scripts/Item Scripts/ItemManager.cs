using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject itemObject { get; set; }
    public bool itemHeld = false;

    public GameObject shooting;

    public void displaySprite(GameObject item)
    {
        itemObject = item;
        gameObject.GetComponent<SpriteRenderer>().sprite = itemObject.GetComponent<Item>().sprite;


        itemHeld = true;
    }

    public void ShootItem()
    {
        if(itemObject != null && itemHeld == true)
        {
            Instantiate(itemObject, shooting.transform.position, new Quaternion(0, 0, 0, 0));
            itemObject = null;
            itemHeld = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = null;
        }
    }
}
