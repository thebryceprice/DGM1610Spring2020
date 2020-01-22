using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class HealthPack : MonoBehaviour
{
    public int healthPack;
    public UnityEvent hValue;

    void Start()
    {
        healthPack = 0;
        hValue.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            healthPack = healthPack + 5;
        }
    }
}