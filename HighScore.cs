using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    Text text;
    public int highscore;


    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        highscore = PlayerPrefs.GetInt("HighScore");
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "" + highscore;
    }
}
