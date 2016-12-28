using UnityEngine;
using System.Collections;

public class AdCount : MonoBehaviour {

    public int ADCount;

	// Use this for initialization
	void Start ()
    {
        ADCount = PlayerPrefs.GetInt("adcount");
        PlayerPrefs.SetInt("adcount", PlayerPrefs.GetInt("adcount") + 1);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(ADCount > 4)
        { 
            PlayerPrefs.SetInt("adcount", 0);
            PlayerPrefs.SetInt("AD", 0);
        }
	}
}
