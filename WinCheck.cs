using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class WinCheck : MonoBehaviour
{
    public int Yolks;


    void Start()
    {
        Time.timeScale = 1;
        Yolks = PlayerPrefs.GetInt("Yolks");

        if (Yolks > 4)
        {
            Application.LoadLevel("win");
        }
    }



    public void Update()
    {
        Yolks = PlayerPrefs.GetInt("Yolks");

        if (Yolks > 4)
        {
            Application.LoadLevel("win");
        }
    }

}