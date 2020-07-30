using System.Collections;
using System.Collections.Generic;
//using System.Threading;
//using UnityEditor.UIElements;
//using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.Advertisements;

public class TimerScript : MonoBehaviour
{
    Image timerBar;
    private float maxTime = 4.0f;
    public float timeLeft;
    public GameObject timesUpText;
    public GameObject Frog;
    public GameObject StageUpText;
    public GameObject Retry;
    public GameObject CameraMea;
    public GameObject HighScore;
    private GameObject Spawnu;
    public GameObject ReclamaButton;
    public float TimerAdd = 0.4f;
    private int ok = 0;
    string GooglePlay_ID = "3703581";
    private bool ok2 = false;
    private bool ok3 = false;
    private float TimeElapse = 1;
    private float TimeElapse2 = 0;
    private int Timp;
    void Start()
    {
        timesUpText.SetActive(false);
        StageUpText.SetActive(false);
        timerBar = GetComponent<Image>();
        Spawnu = GameObject.FindGameObjectWithTag("spawn");
        timeLeft = maxTime;
        Advertisement.Initialize(GooglePlay_ID);
        TimeElapse = 1;
        Retry.SetActive(false);
        HighScore.SetActive(false);
        ReclamaButton.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    { 
            TimeElapse = TimeElapse + Time.deltaTime;
            TimeElapse2 = TimeElapse2 + Time.deltaTime;
            if (Frog.activeSelf == false)
                {
            timeLeft = 0;
                }   
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                timerBar.fillAmount = timeLeft / maxTime;
            }
            else
            {
            if (Frog.activeSelf == true) Frog.SetActive(false);
                timesUpText.SetActive(true);
                Retry.SetActive(true);
                HighScore.SetActive(true);
                if (ReclamaButton != null)
                ReclamaButton.SetActive(true);
            }
            if (timeLeft < 10 && Input.GetKeyDown(KeyCode.Mouse0) && timeLeft > 0)
            {
                if (TimerAdd + timeLeft < maxTime)
                    timeLeft = timeLeft + TimerAdd;
                else
                    timeLeft = maxTime;
                timerBar.fillAmount = timeLeft / maxTime;
                ok++;
            }
            if (ok % 25 == 0 && ok != 0 && Input.GetKeyDown(KeyCode.Mouse0) && TimerAdd > 0.17)
            {
                TimerAdd = TimerAdd - 0.025f;
                TimeElapse = 0;
            }

            if (ok % 50 == 0 && Frog.activeSelf == true && Input.GetKeyDown(KeyCode.Mouse0))
            {
                Timp = 8;
            if (ok != 0)
            {
                if (TimerAdd >= 0.2) TimerAdd = TimerAdd - (float)0.076;
                else 
                if (maxTime > 3f) maxTime = maxTime - 0.51f;
            }
            
                StageUpText.GetComponent<StageScript>().StageNumber++;
                timeLeft = maxTime;
            }
            if (Timp != 0 && Input.GetKeyDown(KeyCode.Mouse0))
            {
                StageUpText.SetActive(true);
                Timp--;
            }
            if (Timp == 0)
            {
                StageUpText.SetActive(false);
            }
        if ((int)Time.time % 45 == 0 && Time.time != 0 && ok3 == false) { ok2 = true; ok3 = true; }
        if (Frog.activeSelf != true)
        {
            if ( ok2 == true)
            {
                if (Advertisement.IsReady("video"))
                    Advertisement.Show("video");
                else if (Advertisement.IsReady("Interstitial"))
                    Advertisement.Show("Interstitial");
                ok2 = false;
            }
        }



    }
    public void RetryButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    [System.Obsolete]
    public void InvieBroascaButton()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show("rewardedVideo", options);

        }
    }
    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Frog.SetActive(true);
                CameraMea.GetComponent<PosOfCam>().PlayerAudio.UnPause();
                Spawnu.SetActive(true);
                Retry.SetActive(false);
                HighScore.SetActive(false);
                timesUpText.SetActive(false);
                Destroy(ReclamaButton);
                timeLeft = 10;
                TimerAdd = TimerAdd + 0.1f;
                break;
            case ShowResult.Skipped:
                break;
            case ShowResult.Failed:
                break;
        }
    }
}

