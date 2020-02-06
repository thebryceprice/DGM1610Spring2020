using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamagePlatformController : MonoBehaviour
{
    [SerializeField] private float platformDamage;
    [SerializeField] private HealthController healthController;
    
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            ConstantDamage();
            print("ow");
        }
    }
    
    void ConstantDamage()
    {
        healthController.playerHealth = healthController.playerHealth - platformDamage;
        healthController.UpdateHealth();
        SceneManager.LoadScene("PracticeScene");
    }
}