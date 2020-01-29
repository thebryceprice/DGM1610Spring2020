using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggeringEvents : MonoBehaviour
{
    public int practiceHealth;
    public bool damaged;
    //public string

    public UnityEvent shot;
    public UnityEvent healthBarUpdate;

    private void Start()
    {
        practiceHealth = 10;
    }

    private void OnTriggerEnter(Collider other)
    {
        damaged = true;
        practiceHealth = practiceHealth - 5;
        shot.Invoke();
        print("Ouch");
    }

    private void OnTriggerStay(Collider other)
    {
        practiceHealth = practiceHealth + 5;
        print("I'm healing!");
    }

    private void OnTriggerExit(Collider other)
    {
        print("All healed up!");
        GetComponent<ParticleSystem>();
    }
}
