using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MoneyController : MonoBehaviour
{
    public float money;
    [SerializeField] private Text currentMoneyText;

    void Start()
    {
        money = 0;
    }
    
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            moneyIncrease();
        }
    }

    void moneyIncrease()
    {
        money = money + 10;
        UpdateMoney();
        gameObject.SetActive(false);
    }
    
    public void UpdateMoney()
    {
        currentMoneyText.text = money.ToString("0");
    }
}