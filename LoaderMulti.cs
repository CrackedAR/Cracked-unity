using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class LoaderMulti : MonoBehaviour
{
    public float timeLeft = 3.0f;


    void Start()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("Yolks", 0);
        PlayerPrefs.SetInt("MultiScore", PlayerPrefs.GetInt("MultiScore") + 1);
    }



    public void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0.0f)
        {
            Application.LoadLevel("PunBasics-Launcher");
        }
    }

}