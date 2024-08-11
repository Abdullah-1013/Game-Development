using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayScripts : MonoBehaviour
{
    public GameObject tapCountText;
    public GameObject winpanel;
    public GameObject ResumePanel;
    public GameObject gameoverpanel;
    public GameObject TimerText;
    public GameManager gameManager;
    public GameObject HighScoreText;
    public GameObject CountDownText;
    public bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        // If you need to initialize anything, you can do it here
    }

    void BackBtnClicked()
    {
        SceneManager.LoadScene(0);
    }
    public void UpdateText()
    {
        tapCountText.GetComponent<Text>().text = gameManager.tapCount.ToString();
        TimerText.GetComponent<Text>().text = gameManager.Timer.ToString();
        if(!gameManager.countdowntimerhasended)
            CountDownText.GetComponent<Text>().text = gameManager.countdowntimer.ToString()[0].ToString();


    }
    public void Highscoretext()
    {
        HighScoreText.GetComponent<Text>().text = "High Score " + GameManager.highscore.ToString();

    }
    public void DisableCountDownTimer()
    {
        CountDownText.gameObject.SetActive(false);
    }
    public void end()
    {
        
        if (gameManager.HasWon == true)
        {
            winpanel.SetActive(true);
        }
        else
        {
            gameoverpanel.SetActive(true);
        }
    }

    public void restartgame()
    {
        SceneManager.LoadScene(1);
    }
    public void mainmenu()
    {
        SceneManager.LoadScene(0);

    }
    public void Pause()
    {
        Time.timeScale = 0;
        isPaused = true;
        ResumePanel.SetActive(true);
   
    }
    public void Resume()
    {
        Time.timeScale = 1;
        isPaused = false;
        ResumePanel.SetActive(false);

    }

}
