using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class LoseCheckEnd : MonoBehaviour
{
    public int Yolks;


    void Start()
    {
        Time.timeScale = 1;
        Yolks = PlayerPrefs.GetInt("Yolks");

        if (Yolks > 0 && Yolks <5 )
        {
            Application.LoadLevel("lose");
        }
    }



    public void Update()
    {
        Yolks = PlayerPrefs.GetInt("Yolks");

        if (Yolks > 0 && Yolks <5 )
        {
            Application.LoadLevel("lose");
        }
    }

}