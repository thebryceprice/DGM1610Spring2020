using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public int money;
    //Intent: If Player collides with a Sprite with the Ammo script, then Disable the sprite and Update Ammo amount
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }
}
