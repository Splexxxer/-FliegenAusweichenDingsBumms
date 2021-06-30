using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOldOne : MonoBehaviour
{    
    public bool isTriggered = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isTriggered == false)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
