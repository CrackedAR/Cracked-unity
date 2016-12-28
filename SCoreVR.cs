using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SCoreVR : MonoBehaviour {

    public int score;
    public int highscore;
    Text text;

	// Use this for initialization
	void Start ()
    {
        text = GetComponent<Text>();
        score = 0;
        highscore = PlayerPrefs.GetInt("HighScoreVR");
	}
	
	// Update is called once per frame
	void Update ()
    {
        text.text = "" + score;

        PlayerPrefs.SetInt("LastScoreVR", score);

        if (score > highscore)
        { PlayerPrefs.SetInt("HighScoreVR", score); }

	}

    public void AddPoints()
    {
        score ++;
    }
}
