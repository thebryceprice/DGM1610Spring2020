using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private void Update()
    {
        if (currentHealth == 0)
        {
            SceneManager.LoadScene("PracticeScene");
        }
    }
}
