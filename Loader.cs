using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour
{
    public float timeLeft = 3.0f;


    void Start()
    {
        Time.timeScale = 1;
        PlayerPrefs.SetInt("AD", 0);
        PlayerPrefs.SetInt("mute", 0);
    }



    public void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0.0f)
        {
            Application.LoadLevel("Main");
        }
    }

}