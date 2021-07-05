using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneratorStart : MonoBehaviour
{
    public List<GameObject> positions = new List<GameObject>();
    public List<GameObject> levelParts = new List<GameObject>();

    void Start()
    {       
        SpawnLevelPart(positions, levelParts);       
    }

    private int SelectLevelPart()
    {
        int randomLevelPart = Random.Range(0,levelParts.Count + 1);
        return randomLevelPart;
    }

    void SpawnLevelPart(List<GameObject> positions, List<GameObject> levelParts)
    {
        foreach(GameObject positionX in positions)
        {
            Instantiate(levelParts[SelectLevelPart()], positionX.transform.position, new Quaternion(0,0,0,0));
        }
    }


}
