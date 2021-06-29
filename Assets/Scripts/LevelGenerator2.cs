using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator2 : MonoBehaviour
{

    public Gameobject position1;
    public Gameobject position2;
    public Gameobject position3;
    public List<Gameobject> positions = new List<Gameobject>;


    void Start()
    {
       
        positions.Add(position1);
        positions.Add(position2);
        positions.Add(position3);
        SpawnLevelPart();
    }

    private int SelectLevelPart()
    {
        int randomLevelPart = new Random.range(1,3);
        return randomLevelPart;
    }

    void SpawnLevelPart()
    {
        foreach(positionX in positions)
        {
            Instantiate(Resource.Load("Assets/Prefabs/Wald/LevelPart_" + SelectLevelPart()), positionX.transform.position, Quanternion(0, 0, 0))
        }
    }


}
