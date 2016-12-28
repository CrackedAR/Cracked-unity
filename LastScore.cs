using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LastScore : MonoBehaviour {

    Text text;
    public int lastscore;


	// Use this for initialization
	void Start ()
    {
        text = GetComponent<Text>();
        lastscore = PlayerPrefs.GetInt ("LastScore");
	}
	
	// Update is called once per frame
	void Update ()
    {
        text.text = "" + lastscore;
	}
}
