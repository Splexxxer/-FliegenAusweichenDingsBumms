using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollforItem : MonoBehaviour
{
    public List<GameObject> items;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponentInChildren<ItemManager>().itemHeld == false)
        {
            collision.gameObject.GetComponentInChildren<ItemManager>().displaySprite(RollItem(items));
            Destroy(gameObject);
        }
    }

    public GameObject RollItem(List<GameObject> listOfItems)
    {
        bool selectedItem = false;
        int randomInt = 0;

        while(selectedItem == false)    //100 is 99% 101 would be 100%
        {
            randomInt = Random.Range(0, listOfItems.Count);
            int randomChance = Random.Range(0, 100);
            if(listOfItems[randomInt].GetComponent<Item>().chance > randomChance)
            {
                selectedItem = true;
                return listOfItems[randomInt];
            }
        }
        Debug.LogError("Triggered null Item");
        return null;
    }
        
}
