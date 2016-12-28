using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour {

    public bool isPlay;
    public bool isStart;
    public bool isHelp;
    public bool isModes;
    public bool isNormal;
    public bool isAR;
    public bool Multi;
    public bool isAR2;
    public bool AR2Help;
    public bool HelpForAR;
    public bool isARModes;
    public bool isMain;
    public bool isExit;
    public bool GiveUp;
    public bool ARHelp;
    public bool GameHelp;
    public bool options;
    public bool sound;
    public bool twitter;
    public bool gyro;
    public bool gyroON;
    public bool gyroOFF;
    public bool Rules;
    public bool VR;

    public bool eggy;
    public bool soldier;
    public bool mayor;

    public int Delay;
    public GameObject music;
    public LifeManager Life;
    public VirtualJoystick control;
    public GameObject Player;

    public int Mute;
    

	// Use this for initialization
	void Start ()
    {
        Player = GameObject.Find("PlayerBall");
        Life = FindObjectOfType<LifeManager>();
        control = FindObjectOfType<VirtualJoystick>();

        if (GameObject.Find("Virtual joystick") != null)
        {
            control.enabled = false;
        }

        if (GameObject.Find("Virtual joystick") != null)
        {
            Player.GetComponent<BallMotor>().enabled = false;
        }

        Mute = PlayerPrefs.GetInt("mute");

        if (GameObject.Find("Virtual joystick") != null)
        {
            Life.FillLife();
        }
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        Player = GameObject.Find("PlayerBall");
        Life = FindObjectOfType<LifeManager>();
        control = FindObjectOfType<VirtualJoystick>();



        if (GameObject.Find("Virtual joystick") != null)
        {
            control.enabled = false;
        }

        if (GameObject.Find("Virtual joystick") != null)
        {
            Player.GetComponent<BallMotor>().enabled = false;
        }

        Mute = PlayerPrefs.GetInt("mute");

        if (Input.GetKeyDown(KeyCode.Escape))
        { Application.LoadLevel("Main"); }

        if (GameObject.Find("Virtual joystick") != null)
        {
            Life.FillLife();
        }

	}

    public enum Trigger
    {
        OnClick
    }

    public void OnMouseDown()
    {

        if (isAR) { StartCoroutine("ARCo"); }

        if (isStart) { StartCoroutine("StartCo"); }

        if (isAR2) { StartCoroutine("AR2Co"); }

        if (isARModes) { StartCoroutine("ARModesCo"); }

        if (isNormal) { StartCoroutine("NormCo"); }

        if (VR) { StartCoroutine("VRCo"); }

        if (gyro) { StartCoroutine("gyroCo"); }

        if (Rules) { StartCoroutine("RuleCo"); }

        if (isMain) { StartCoroutine("MainCo"); }

        if (isModes) { StartCoroutine("ModesCo"); }

        if (Multi) { StartCoroutine("MultiCo"); }

        if (isHelp) { StartCoroutine("HelpCo"); }

        if (isExit) { StartCoroutine("ExitCo"); }

        if (GiveUp) { StartCoroutine("GiveUpCo"); }

        if (ARHelp) { StartCoroutine("ARHelpCo"); }

        if (AR2Help) { StartCoroutine("AR2HelpCo"); }

        if (HelpForAR) { StartCoroutine("HelpforARCo"); }

        if (GameHelp) { StartCoroutine("GameHelpCo"); }

        if (options) { StartCoroutine("OptionsCo"); }

        if (eggy) { StartCoroutine("eggyCo"); }

        if (soldier) { StartCoroutine("soldierCo"); }

        if (mayor) { StartCoroutine("mayorCo"); }

        if (sound) { StartCoroutine("soundCo"); }

        if (twitter) { StartCoroutine("twitterCo"); }

        if (gyroON) { StartCoroutine("gyroONCo"); }

        if (gyroOFF) { StartCoroutine("gyroOFFCo"); }

    }

    public IEnumerator ExitCo()
    {
        Handheld.Vibrate();
        yield return new WaitForSeconds(Delay);
        Application.Quit();
    }

    public IEnumerator ARCo()
    {
        GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("AR");
    }

    public IEnumerator AR2Co()
    {
        GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("AR2");
    }

    public IEnumerator NormCo()
    {
        GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("Normal");
    }

    public IEnumerator MainCo()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("Main");
    }

    public IEnumerator HelpforARCo()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("HelpForAR");
    }

    public IEnumerator AR2HelpCo()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("AR2Help");
    }

    public IEnumerator ModesCo()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("Modes");
    }

    public IEnumerator ARModesCo()
    {
        GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("ARModes");
    }

    public IEnumerator HelpCo()
    {
        GetComponent<AudioSource>().Play ();
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("Help");
    }

    public IEnumerator GiveUpCo()
    {
        Instantiate(music, music.transform.position, music.transform.rotation);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("Main");
    }

    public IEnumerator ARHelpCo()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("ARHelp");
    }

    public IEnumerator GameHelpCo()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("GameHelp");
    }

    public IEnumerator gyroCo()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("GYRO");
    }

    public IEnumerator OptionsCo()
    {
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("options");
    }

    public IEnumerator eggyCo()
    {
        GetComponent<AudioSource>().Play();
        PlayerPrefs.SetInt("PlayerNO", 0);
        GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("Main");
    }

    public IEnumerator soldierCo()
    {
        GetComponent<AudioSource>().Play();
        PlayerPrefs.SetInt("PlayerNO", 1);
        GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("Main");
    }

    public IEnumerator mayorCo()
    {
        GetComponent<AudioSource>().Play();
        PlayerPrefs.SetInt("PlayerNO", 2);
        GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(Delay);
        Application.LoadLevel("Main");
    }

    public IEnumerator soundCo()
    {
        if (Mute == 0)
        {
            Handheld.Vibrate();
            AudioListener.volume = 0.0f;
            PlayerPrefs.SetInt("mute", 1);

        }
        if (Mute == 1)
        {
            Handheld.Vibrate();
            AudioListener.volume = 1.0f;
            PlayerPrefs.SetInt("mute", 0);

        }

        yield return new WaitForSeconds(Delay);
        
    }

    public IEnumerator twitterCo()
    {
        Application.OpenURL("https://twitter.com/Cracked_AR");
        yield return new WaitForSeconds(Delay);

    }

    public IEnumerator StartCo()
    {
        yield return new WaitForSeconds(Delay);
        control.enabled = true;
        Player.GetComponent<BallMotor>().enabled = true;
        Life.FillLife();
        PlayerPrefs.SetInt("Die", 1);
        Destroy(this.gameObject);
    }

    public IEnumerator MultiCo()
    {
        yield return new WaitForSeconds(0);
        Application.LoadLevel("PunBasics-Launcher");
    }

    public IEnumerator VRCo()
    {
        yield return new WaitForSeconds(0);
        Application.LoadLevel("VR");
    }

    public IEnumerator RuleCo()
    {
        yield return new WaitForSeconds(0);
        Application.LoadLevel("rules");
    }

    public IEnumerator gyroONCo()
    {
        PlayerPrefs.SetInt("Gyro", 1);
        GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(2);
        Application.LoadLevel("Normal");
    }

    public IEnumerator gyroOFFCo()
    {
        PlayerPrefs.SetInt("Gyro", 0);
        GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(2);
        Application.LoadLevel("Normal");
    }

    
    
}
