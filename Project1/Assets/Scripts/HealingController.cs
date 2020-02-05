using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealingController : MonoBehaviour
{
    [SerializeField] private float healthpackHealing;
    [SerializeField] private HealthController healthController;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Healing();
        }
    }

    void Healing()
    {
        healthController.playerHealth = healthController.playerHealth + healthpackHealing;
        healthController.UpdateHealth();
        gameObject.SetActive(false);
    }
}