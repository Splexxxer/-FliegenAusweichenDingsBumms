using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillScript : MonoBehaviour
{
    public GameObject ded;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
        StartCoroutine(waiter());
    }


    IEnumerator waiter()
    {
        ded.SetActive(true);
        yield return new WaitForSeconds(1);
        ded.SetActive(false);
    }
}
