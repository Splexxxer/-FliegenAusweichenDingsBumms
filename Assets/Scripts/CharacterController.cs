using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 5f;
    
    void Update()
    {
        float vHorizontal = Input.GetAxisRaw("HorizontalPlayer1");
        float vVertical = Input.GetAxisRaw("VerticalPlayer1");

        GetComponent<Rigidbody2D>().velocity = new Vector2(vHorizontal, vVertical) * speed;     
    }
}
