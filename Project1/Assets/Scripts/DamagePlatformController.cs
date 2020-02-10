using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class DamagePlatformController : MonoBehaviour
{
    [SerializeField] private float platformDamage;
    [SerializeField] private HealthController healthController;


    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            WallDamage();
            print("ow");
        }
    }
    
    void WallDamage()
    {
        healthController.playerHealth = healthController.playerHealth - platformDamage;
        healthController.UpdateHealth();
        SceneManager.LoadScene("PracticeScene");
        //GameObject.Find("TESTPLAYER").transform.position
    }
}