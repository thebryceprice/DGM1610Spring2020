﻿using UnityEngine;

public class IfStatements : MonoBehaviour
{
    public int a = 10;
    public int b = 4;
    public int c = 14;
    public string password = "OU812";
    public bool canRun = true;

    void Start()
    {
        if (a+b == c)
        {
            print("That is true.");
        }


        if (password == "OU812")
        {
            print("That is the correct password");
        }

        if (canRun)
        {
            print("We can run");
        }
        
    }


    void Update()
    {
        
    }
}
