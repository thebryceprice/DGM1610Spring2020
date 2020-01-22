using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUps : MonoBehaviour
{
    public static UnityEvent moneyEvent;
    public static UnityEvent ammoEvent;
    public static UnityEvent healingEvent;
    
    public static int ammo;
    public static int money;
    //public float healing;

    public void Start()
    {
        ammo = 0;
        money = 0;
        //healing = 0;
    }

    private void Update()
    {
        print(ammo);
        print(money);
        //print(healing);
    }
}
