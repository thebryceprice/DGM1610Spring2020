using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public float playerHealth;
    [SerializeField] private Text currentHealthText;


    private void Start()
    {
        UpdateHealth();;
    }

    public void UpdateHealth()
    {
        //converts currentHealth float value into a string value to allow it to be put into text box
        currentHealthText.text = playerHealth.ToString("0");
    }
}
