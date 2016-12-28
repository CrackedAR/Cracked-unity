using UnityEngine;
using System.Collections;

public class GYRO : MonoBehaviour {

    public int gyro;

	// Use this for initialization
	void Start () 
    {
        gyro = PlayerPrefs.GetInt("Gyro");

        if (gyro == 1)
        {
            if (GameObject.Find("Virtual joystick") != null)
            {
                (GameObject.Find("BG")).transform.localScale = new Vector3(0, 0, 0);
            }
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
}
