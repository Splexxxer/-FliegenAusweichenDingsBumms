using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Transform LevelPart_1;

    private void Awake()
    {
        Transform LastLevelPartTransform;
        LastLevelPartTransform = SpawnLevelPart(LastLevelPartTransform.Find("EndPosition").position);
        LastLevelPartTransform = SpawnLevelPart(LastLevelPartTransform.Find("EndPosition").position);
        LastLevelPartTransform = SpawnLevelPart(LastLevelPartTransform.Find("EndPosition").position);
        LastLevelPartTransform = SpawnLevelPart(LastLevelPartTransform.Find("EndPosition").position);
        LastLevelPartTransform = SpawnLevelPart(LastLevelPartTransform.Find("EndPosition").position);
        LastLevelPartTransform = SpawnLevelPart(LastLevelPartTransform.Find("EndPosition").position);
        LastLevelPartTransform = SpawnLevelPart(LastLevelPartTransform.Find("EndPosition").position);
        LastLevelPartTransform = SpawnLevelPart(LastLevelPartTransform.Find("EndPosition").position);
        LastLevelPartTransform = SpawnLevelPart(LastLevelPartTransform.Find("EndPosition").position);
        LastLevelPartTransform = SpawnLevelPart(LastLevelPartTransform.Find("EndPosition").position);
    }

    private Transform SpawnLevelPart(Vector2 Spawnposition)
    {
        Transform LevelPartTransform = Instantiate(LevelPart_1, Spawnposition, Quaternion.identity);
        return LevelPartTransform;
    }

}