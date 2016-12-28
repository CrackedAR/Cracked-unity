using UnityEngine;
using System.Collections;
using GooglePlayGames;
using UnityEngine.SocialPlatforms;

public class OnlineScore : MonoBehaviour {

    static int MyScore;
    static int MyMultiScore;
    static int HighScoreVR;
    static int Achieve;

	// Use this for initialization
	void Start () 
    {
        // recommended for debugging:
        PlayGamesPlatform.DebugLogEnabled = true;

        // Activate the Google Play Games platform
        PlayGamesPlatform.Activate();

        //Login

        login();

        UpdateScore();
    

        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { Application.LoadLevel("Main"); }
	
	}

    public void OnShowLeaderBoard()
    {
        if (Social.localUser.authenticated)
        {
            ((PlayGamesPlatform)Social.Active).ShowLeaderboardUI();
        }
        else { Start(); }
    }

    public void login()
    {
        Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
                Debug.Log("Login Sucess");
            }
            else
            {
                Debug.Log("Login failed");
            }
        });
    }



    public void UpdateScore()
    {
        //Update Score

        MyScore = PlayerPrefs.GetInt("HighScore");
        MyMultiScore = PlayerPrefs.GetInt("MultiScore");
        HighScoreVR = PlayerPrefs.GetInt("HighScoreVR");
        Achieve = PlayerPrefs.GetInt("Achieve");

        if (Social.localUser.authenticated)
        {
            Social.ReportScore(MyScore, "CgkI5_jN4I0VEAIQAQ", (bool success) =>
            {
                if (success)
                {
                    Debug.Log("Update Score Success");
                }
                else
                {
                    Debug.Log("Update Score Fail");
                }
            });

            Social.ReportScore(MyMultiScore, "CgkI5_jN4I0VEAIQAg", (bool success) =>
            {
                if (success)
                {
                    Debug.Log("Update Score Success");
                }
                else
                {
                    Debug.Log("Update Score Fail");
                }
            });

            Social.ReportScore(HighScoreVR, "CgkI5_jN4I0VEAIQCA", (bool success) =>
            {
                if (success)
                {
                    Debug.Log("Update Score Success");
                }
                else
                {
                    Debug.Log("Update Score Fail");
                }
            });
        }
        else
        {
            login();
        }



        if (MyMultiScore >= 1 && Achieve == 0)
        {
            PlayerPrefs.SetInt("Achieve", 1);
            Social.ReportProgress("CgkI5_jN4I0VEAIQAw", 100.0f, (bool success) =>
            {
                if (success)
                {
                    Debug.Log("Update Success");

                }
                else
                {
                    Debug.Log("Update Fail");
                }
            });
        }


        if (MyMultiScore >= 10 && Achieve ==1)
        {
            PlayerPrefs.SetInt("Achieve", 2);
            Social.ReportProgress("CgkI5_jN4I0VEAIQBA", 100.0f, (bool success) =>
            {
                if (success)
                {
                    Debug.Log("Update Success");

                }
                else
                {
                    Debug.Log("Update Fail");
                }
            });
        }


        if (MyMultiScore >= 30 && Achieve == 2)
        {
            PlayerPrefs.SetInt("Achieve", 3);
            Social.ReportProgress("CgkI5_jN4I0VEAIQBQ", 100.0f, (bool success) =>
            {
                if (success)
                {
                    Debug.Log("Update Success");

                }
                else
                {
                    Debug.Log("Update Fail");
                }
            });
        }


        if (MyMultiScore >= 70 && Achieve == 3)
        {
            PlayerPrefs.SetInt("Achieve", 4);
            Social.ReportProgress("CgkI5_jN4I0VEAIQBg", 100.0f, (bool success) =>
            {
                if (success)
                {
                    Debug.Log("Update Success");

                }
                else
                {
                    Debug.Log("Update Fail");
                }
            });
        }


        if (MyMultiScore >= 100 && Achieve == 5)
        {
            PlayerPrefs.SetInt("Achieve", 6);
            Social.ReportProgress("CgkI5_jN4I0VEAIQBw", 100.0f, (bool success) =>
            {
                if (success)
                {
                    Debug.Log("Update Success");

                }
                else
                {
                    Debug.Log("Update Fail");
                }
            });
        }



	
    }
}
