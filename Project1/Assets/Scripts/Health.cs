using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 100;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            currentHealth = currentHealth - 10;
        }

    }
}
