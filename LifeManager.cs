using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeManager : MonoBehaviour
{

    public Slider Life;

    public int FullLife;

    private int EmptyLife = 0;

    private int AvailLife;

    public bool isAR;

    public bool isNormal;

    public bool isAR2;




    // Use this for initialization
    void Start()
    {
        Life = GetComponent<Slider>();
        AvailLife = FullLife;

        if (isNormal) 
        {
            FullLife = 6;
        }
        else 
        {
            FullLife = 7; 
        }
        
    }

    // Update is called once per frame
    void Update()
    {

        if (isNormal)
        {
            FullLife = 6;
        }
        else
        {
            FullLife = 7;
        }

        Life.value = AvailLife;

        if (AvailLife == 0)
        {
            PlayerPrefs.SetInt("Die", 0);

            if (isAR) { Application.LoadLevel("GAMEOVER"); }

            if (isNormal) { Application.LoadLevel("GAMEOVERNorm"); }

            if (isAR2) { Application.LoadLevel("GAMEOVERAR2"); }

        }

    }

    public void FillLife()
    {
        AvailLife = FullLife;
    }

    public void TwoLife()
    {
        AvailLife += 3;
    }

    public void Reduce()
    {
        AvailLife -= 1;
    }

}
