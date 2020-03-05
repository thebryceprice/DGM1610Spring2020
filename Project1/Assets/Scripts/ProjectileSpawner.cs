using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(ParticleSystem))]

public class ProjectileSpawner : MonoBehaviour
{
    public UnityEvent particleColor;
    private ParticleSystem particleObj;


    private void Start()
    {
        particleColor.Invoke();
        particleObj.Pause();
    }

    private void OnMouseDown()
    {
        particleObj.Play();
    }
}
