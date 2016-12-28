using System.Collections;
using UnityEngine;

public class UpdateManger : MonoBehaviour
{

    public LifeManager Life;
    public SCore score;
    public BallMotor Player;
    public GameObject spawnPart;
    public GameObject BluePart;

    //Use for Player spawning
    public int PlayerNo;
    public GameObject Hatter;

    public GameObject EggNULL;
    public GameObject EggHelmet;
    public GameObject EggHat;


    //gameobject for Yolk spawning 
    public GameObject spawnObj;
    public GameObject spawnObj2;
    public GameObject imageT;
    public GameObject costume;
    public GameObject spawnpoint;
    public GameObject spawnpoint2;
    public int Delay = 20;

    // Use this for initialization
    void Start()
    {
        Life = FindObjectOfType<LifeManager>();
        score = FindObjectOfType<SCore>();
        Player = FindObjectOfType<BallMotor>();
        PlayerNo = PlayerPrefs.GetInt("PlayerNO");
        StartCoroutine("LessLifeCo");
        




        if (PlayerNo == 1)
        {
            GameObject obnew = (GameObject)Instantiate(EggHelmet, Hatter.transform.position, Player.transform.rotation);
            obnew.transform.parent = costume.gameObject.transform;
            Debug.Log("Helmet Spawned");
        }

        else if (PlayerNo == 2)
        {
            GameObject obnew = (GameObject)Instantiate(EggHat, Hatter.transform.position, Player.transform.rotation);
            obnew.transform.parent = costume.gameObject.transform;
            Debug.Log("HAt Spawned");
        }

        else
        {
            GameObject obnew = (GameObject)Instantiate(EggNULL, Player.transform.position, Player.transform.rotation);
            obnew.transform.parent = costume.gameObject.transform;
            Debug.Log("Null Spawned");
        }
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "grow")
        {
            score.AddPoints();
            GetComponent<AudioSource>().Play();
            SpawnCo();
            Life.FillLife();
            Destroy(other.gameObject);
            Instantiate(spawnPart, other.transform.position, other.transform.rotation);
        }

        if (other.tag == "speed")
        {
            score.AddPoints();
            Life.GetComponent<AudioSource>().Play();
            BlueSpawnCo();
            Life.TwoLife();
            Destroy(other.gameObject);
            Instantiate(BluePart, other.transform.position, other.transform.rotation);
        }
    }


    void SpawnCo()
    {
        Instantiate(spawnPart, spawnpoint.transform.position, spawnpoint.transform.rotation);
        GameObject obnew = (GameObject)Instantiate(spawnObj, spawnpoint.transform.position, spawnpoint.transform.rotation);
        obnew.transform.parent = imageT.gameObject.transform;
        Debug.Log("Yellow Spawned");
    }


    void BlueSpawnCo()
    {
        StartCoroutine("speedCo");
        
    }

    public IEnumerator speedCo()
    {
        Player.moveSpeed = 50;
        yield return new WaitForSeconds(Delay);
        Player.moveSpeed = 30;
        score.GetComponent<AudioSource>().Play();
        Instantiate(BluePart, spawnpoint2.transform.position, spawnpoint2.transform.rotation);
        GameObject obnew2 = (GameObject)Instantiate(spawnObj2, spawnpoint2.transform.position, spawnpoint2.transform.rotation);
        obnew2.transform.parent = imageT.gameObject.transform;
        Debug.Log("Blue Spawned");
    }

    //Start reducing FullLIfe Value;
    public IEnumerator LessLifeCo()
    {
        yield return new WaitForSeconds(180);
        Life.FullLife = 5;
        StartCoroutine("LessLife2Co");
    }

    public IEnumerator LessLife2Co()
    {
        yield return new WaitForSeconds(120);
        Life.FullLife = 4;
    }

   
}
