using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class TerrainCreator2 : MonoBehaviour
{
    public SpriteShapeController shape;
    public int scale = 100;
    public int points = 150;

    public float lowestNumofRange = 5f;
    public float highestNumofRange = 15f;
    public int diffrenceInHeight = 10;

    public int tangentLength = 2;

    public void Start()
    {
        float pointsDistance = (float)scale / (float)points;

        shape = GetComponent<SpriteShapeController>();

        shape.spline.SetPosition(2, shape.spline.GetPosition(2) + Vector3.right * scale);
        shape.spline.SetPosition(3, shape.spline.GetPosition(3) + Vector3.right * scale);

        for (int i = 0; i < points; i++)
        {
            float xPos = shape.spline.GetPosition(i + 1).x + pointsDistance;

            float perlinNoiseNumber = diffrenceInHeight * Mathf.PerlinNoise(i * Random.Range(lowestNumofRange, highestNumofRange), 0);

            shape.spline.InsertPointAt(i + 2, new Vector3(xPos, -perlinNoiseNumber));
        }

        for (int i = 2; i < points; i++)
        {
            shape.spline.SetTangentMode(i, ShapeTangentMode.Continuous);
            shape.spline.SetLeftTangent(i, new Vector3(-tangentLength, 0));
            shape.spline.SetRightTangent(i, new Vector3(tangentLength, 0));
        }
    }

}