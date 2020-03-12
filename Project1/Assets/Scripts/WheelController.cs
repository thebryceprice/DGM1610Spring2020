using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
//initial "speed" is set at 0
    public float rotationSpeed = 0;
    
    void Start()
    {
        
    }
    
    void Update()
    {
        //on every update, while mouse is down, apply rotation value of 10 to objects zed axis
        if (Input.GetMouseButtonDown(0))
        {
            this.rotationSpeed = 15;
        }
        transform.Rotate(0,this.rotationSpeed,0);
        this.rotationSpeed *= 0.99f;
    }
}