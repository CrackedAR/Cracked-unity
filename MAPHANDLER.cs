using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MAPHANDLER : MonoBehaviour {

    public GameObject n1;
    public GameObject n2;
    public GameObject n3;
    public GameObject n4;
    public GameObject n5;
    public GameObject n6;
    public GameObject n7;
    public GameObject n8;
    public GameObject n9;
   

	// Use this for initialization
	void Start () 
    {
        n1.SetActive(false);
        n2.SetActive(false);
        n3.SetActive(false);
        n4.SetActive(false);
        n5.SetActive(false);
        n6.SetActive(false);
        n7.SetActive(false);
        n8.SetActive(false);
        n9.SetActive(false);
       
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ON()
    {
        n1.SetActive(true);
        n2.SetActive(true);
        n3.SetActive(true);
        n4.SetActive(true);
        n5.SetActive(true);
        n6.SetActive(true);
        n7.SetActive(true);
        n8.SetActive(true);
        n9.SetActive(true);
    }
}
