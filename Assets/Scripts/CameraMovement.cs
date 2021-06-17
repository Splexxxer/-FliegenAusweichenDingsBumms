using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{   
    public float speed = 3;
    bool shouldStart = false;

    
    
    void Start()
    {
        Invoke("turnShouldStartTrue", 2);
        
    }
    
    void Update()
    {
        if (shouldStart == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed,0);
           
        }
    }
    
    void turnShouldStartTrue()
    {
        shouldStart = true;
    }

    void getFaster()//Have to be implemented //Maybe
    {
        
    } 
}
