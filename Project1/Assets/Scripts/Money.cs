﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public void ChangeMoneyAmount(int moneyAmount)
    {
        PowerUps.money += moneyAmount;
    }
    
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
            PowerUps.moneyEvent.Invoke();
        }
    }
}
