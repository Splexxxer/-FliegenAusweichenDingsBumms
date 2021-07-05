using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGeneratorStart : MonoBehaviour
{
    public GameObject position1;
    public GameObject position2;
    public GameObject position3;
    public GameObject position4;

    public GameObject levelPart_1;
    public GameObject levelPart_2;
    public GameObject levelPart_3;
    


    void Start()
    {
        List<GameObject> positions = new List<GameObject>();
        positions.Add(position1);
        positions.Add(position2);
        positions.Add(position3);
        positions.Add(position4);

        List<GameObject> levelParts = new List<GameObject>();
        levelParts.Add(levelPart_1);
        levelParts.Add(levelPart_2);
        levelParts.Add(levelPart_3);
        
        SpawnLevelPart(positions, levelParts);       
    }

    private int SelectLevelPart()
    {
        int randomLevelPart = Random.Range(0,3);
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
