using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUps : MonoBehaviour
{
    //Master Script for all PickUps - Scripts like Money/Ammo/HealthPacks values are updated and stored here
    public int ammo;
    public int money;
    //public int healing;

    public void Start()
    {
        ammo = 0;
        money = 0;
        //healing = 0;
    }

    private void Update()
    {
        //print(ammo);
        //print(money);
        //print(healing);
    }
}
