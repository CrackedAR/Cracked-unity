using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SCore : MonoBehaviour {

    public int score;
    public int highscore;
    Text text;

	// Use this for initialization
	void Start ()
    {
        text = GetComponent<Text>();
        score = 0;
        highscore = PlayerPrefs.GetInt("HighScore");
	}
	
	// Update is called once per frame
	void Update ()
    {
        text.text = "" + score;

        PlayerPrefs.SetInt("LastScore", score);

        if (score > highscore)
        { PlayerPrefs.SetInt("HighScore", score); }

	}

    public void AddPoints()
    {
        score ++;
    }
}
