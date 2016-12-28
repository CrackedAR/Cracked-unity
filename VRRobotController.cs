// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayerAnimatorManager.cs" company="Exit Games GmbH">
//   Part of: Photon Unity Networking Demos
// </copyright>
// <summary>
//  Used in DemoAnimator to cdeal with the networked player Animator Component controls.
// </summary>
// <author>developer@exitgames.com</author>
// --------------------------------------------------------------------------------------------------------------------


using UnityEngine;
using System.Collections;

	public class VRRobotController : MonoBehaviour 
	{

		public float DirectionDampTime = 0.25f;
        public SpawnerVR spawner;
        public GameObject spawnPart;
        public SCoreVR score;
        public VRRobotController Robot;
		Animator animator;
       

		
	    void Start () 
	    {
	        animator = GetComponent<Animator>();
            spawner = FindObjectOfType<SpawnerVR>();
            score = FindObjectOfType<SCoreVR>();
            Robot = FindObjectOfType<VRRobotController>();
            Robot.enabled = false;
	    }
	        
		
	    void Update () 
	    {
            if (Input.GetKeyDown(KeyCode.Escape))
            { Application.LoadLevel("Modes"); }

            Screen.sleepTimeout = SleepTimeout.NeverSleep;

			// deal with movement
            float h = Input.acceleration.x;

			

			// set the Animator Parameters
            animator.SetFloat( "Speed", 50 );
            animator.SetFloat( "Direction", h, DirectionDampTime, Time.deltaTime );
        }


         void OnTriggerEnter(Collider other)
    {
        if (other.tag == "grow")
        {
            score.AddPoints();
            GetComponent<AudioSource>().Play();
            spawner.SpawnCo();
            Destroy(other.gameObject);
            Instantiate(spawnPart, other.transform.position, other.transform.rotation);
        }

    }

    public void Begin()
    {
        StartCoroutine("GameVRCo"); 
    }

    public IEnumerator GameVRCo()
    {
        yield return new WaitForSeconds(60);
        Application.LoadLevel("GAMEOVERVR");
    }


}