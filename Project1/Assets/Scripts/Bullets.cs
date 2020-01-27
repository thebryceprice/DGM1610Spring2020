using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
        }
        if (other.gameObject.tag == "Ground")
        {
            gameObject.SetActive(false);
        }
    }
}
