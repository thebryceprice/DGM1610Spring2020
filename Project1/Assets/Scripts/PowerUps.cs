using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public float ammo;
    public float money;
    //public float healing;

    public void Start()
    {
        ammo = 0;
        money = 0;
    }

    private void Update()
    {
        print(ammo);
        print(money);
    }
}
