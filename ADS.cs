using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

public class ADS : MonoBehaviour {

    public int AD;

	// Use this for initialization
	void Start ()
    {
        AD = PlayerPrefs.GetInt("AD");
        if (AD == 0) { ShowAd(); }
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
          StartCoroutine("AdsCo");
        }
    }

    public IEnumerator AdsCo()
    {
        yield return new WaitForSeconds(0);
        PlayerPrefs.SetInt("AD", 1);
        Advertisement.Show();
        Debug.Log("haaaa");
        
    }
}
