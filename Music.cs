using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

    public Music music;

	// Use this for initialization
	void Start () 
    {
        music = FindObjectOfType<Music>();
        GameObject.DontDestroyOnLoad(music);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
