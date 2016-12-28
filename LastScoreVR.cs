using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LastScoreVR : MonoBehaviour {

    Text text;
    public int lastscore;


	// Use this for initialization
	void Start ()
    {
        text = GetComponent<Text>();
        lastscore = PlayerPrefs.GetInt ("LastScoreVR");
	}
	
	// Update is called once per frame
	void Update ()
    {
        text.text = "" + lastscore;
	}
}
