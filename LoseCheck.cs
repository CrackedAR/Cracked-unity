using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class LoseCheck : MonoBehaviour
{
    public int Yolks;


    void Start()
    {
        Time.timeScale = 1;
        Yolks = PlayerPrefs.GetInt("Yolks");

        if (Yolks > 0 )
        {
            PhotonNetwork.LeaveRoom();
        }
    }



    public void Update()
    {
        Yolks = PlayerPrefs.GetInt("Yolks");

        if (Yolks > 0 )
        {
            PhotonNetwork.LeaveRoom();
        }
    }

}