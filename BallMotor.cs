using UnityEngine;
using System.Collections;

public class BallMotor : MonoBehaviour
 {
 	public float moveSpeed = 30.0f;
 	public float drag = 0.5f;
 	public float terminalRotationSpeed = 25.0f;
 	public Vector3 MoveVector {set;get;}
 	public VirtualJoystick joystick;
 	public LifeManager Life;

    public bool Normal;

    public int gyro;

 	int interval = 1; 
    float nextTime = 0;

 	private Rigidbody thisRigidbody;

	// Use this for initialization
	private void Start () 
	{
		thisRigidbody = gameObject.GetComponent<Rigidbody>();
		thisRigidbody.maxAngularVelocity = terminalRotationSpeed;
		thisRigidbody.drag = drag;
		Life = FindObjectOfType<LifeManager>();
	}
	
	// Update is called once per frame
	private void Update () 
	{
        gyro = PlayerPrefs.GetInt("Gyro");

        if(Normal == true && gyro == 1)
        {

         Vector3 movement = new Vector3(Input.acceleration.x, 0.0f, Input.acceleration.y);
         thisRigidbody.AddForce(movement * 120f);
        }


		MoveVector =  PoolInput();

		Move();

		// Update is called once per frame
        if (Time.time >= nextTime)
         	{
                if(PlayerPrefs.GetInt("Die") == 1)
                {
                    nextTime = Time.time;
                    Life.Reduce();
                    nextTime += interval; 
                }    
     
     		}
	}

	private void Move()
	{
		thisRigidbody.AddForce((MoveVector * moveSpeed));
	}

	private Vector3 PoolInput()
	{
		Vector3 dir = Vector3.zero;

		//dir.x = Input.GetAxis("Horizontal");
		//dir.z = Input.GetAxis("Vertical");

		dir.x = joystick.Horizontal();
		dir.z = joystick.Vertical();

		if(dir.magnitude > 1)
			dir.Normalize();

		return dir;
	}

}
