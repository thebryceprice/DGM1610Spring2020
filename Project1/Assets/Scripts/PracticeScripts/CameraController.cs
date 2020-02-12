using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]

public class CameraController : MonoBehaviour
{

    private Camera cameraObj;
    void Start()
    {
        cameraObj = GetComponent<Camera>();
        cameraObj.orthographic = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
