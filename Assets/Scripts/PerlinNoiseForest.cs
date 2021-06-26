using UnityEngine;

public class PerlinNoiseForest : MonoBehaviour
{
    public int width = 265;
    public int height = 265;

    public float scale = 20f;

    public float offsetX = 100f;
    public float offsety = 100f;

    void Start()
    {
        offsetX = Random.Range(0f, 99999f);
        offsetY = Random.Range(0f, 99999f);
    }

    void update()
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = GenerateTexture();
    }

    Texture2D GenerateTexture()
    {
        Texture2D texture = new Texture2D(width, height);

        //Generate Perlin Noise map for the texture
        for (int x = 0; x < width; x++)
        {
            for(int y = 0; y < height; y++)
            {
                Color color = CalculateColor(x,y);
                texture.SetPixel(x, y, color);
            }
        }
        texture.Apply();

        return texture;
    }

    Color CalculateColor(int x, int y)
    {
        float xCoord = (float)x / width * scale;
        float yCoord = (float)y / width * scale;

        float sample = Mathf.PerlinNoise(xCoord, yCoord);
        return new Color(sample, sample, sample);
    }
}
