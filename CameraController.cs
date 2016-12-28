using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public BallMotor player;

	public bool isFollowing;

	// Use this for initialization
	void Start () 
    {
		player = FindObjectOfType<BallMotor> ();

        isFollowing = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        this.gameObject.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
	}
}
