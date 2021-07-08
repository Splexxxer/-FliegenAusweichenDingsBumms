using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewBack : MonoBehaviour
{
    public bool isTriggered = false;

    public int chanceForCave;

    public GameObject objectToSpawn;
    public GameObject objectToSpawn2;
    public GameObject pointToSpawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isTriggered == false)
        {
            int random = Random.Range(0, 100);

            if(chanceForCave <= random) 
            { 
                Instantiate(objectToSpawn, pointToSpawn.transform.position, new Quaternion(0, 0, 0, 0));
            }
            else if (chanceForCave > random)
            {
                Instantiate(objectToSpawn2, pointToSpawn.transform.position, new Quaternion(0, 0, 0, 0));
            }
            else
            {
                Instantiate(objectToSpawn, pointToSpawn.transform.position, new Quaternion(0, 0, 0, 0));
            }
            isTriggered = true;
        }
    }
}
