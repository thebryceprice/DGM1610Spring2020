using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] private float bulletDamage;
    [SerializeField] private HealthController healthController;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Damage();
        }
    }

    void Damage()
    {
        healthController.playerHealth = healthController.playerHealth - bulletDamage;
        healthController.UpdateHealth();
        this.gameObject.SetActive(false);
    }
}
