using UnityEngine;
using System.Collections;

public class MusicDelete : MonoBehaviour {

    public Music music;

	// Use this for initialization
	void Start ()
    {
        music = FindObjectOfType<Music>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (GameObject.Find("Music") != null || GameObject.Find("Music(Clone)") != null)
        {
            Destroy(music.gameObject);
        }
	}
}
