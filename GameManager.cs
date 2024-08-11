using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int tapCount;
    public float Defaulttimervalue = 30;
    public float Timer;
    public bool HasWon;
    public int TargetCount;
    public static int highscore;
    public float countdowntimer;
    public bool countdowntimerhasended;
    public bool timerhasended;



    public GamePlayScripts gamePlayScripts;

    void Start()
    {
        countdowntimer = 3;
        countdowntimerhasended = false;
        Timer = Defaulttimervalue;
        gethighscore();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (!countdowntimerhasended)
        {
            countdowntimer -= Time.deltaTime;

            if (countdowntimer <= 0)
            {
                countdowntimerhasended = true;
                gamePlayScripts.DisableCountDownTimer();
                Debug.Log("Count Down Time Hase Ended: " + countdowntimerhasended);
            }
            // Decrement the timer if it's greater than 0
            if (countdowntimerhasended && timerhasended==false)
            {
                Timer -= Time.deltaTime;
            }
        }

        // Handle the case where the Timer reaches or falls below 0
        if (Timer <= 0)
        {
            Timer = 0; // Ensure the Timer is set to 0 and doesn't go negative
            timerhasended=true;
            if (tapCount > TargetCount)
            {
                HasWon = true;
            }
            else { 
                HasWon= false;
            
            }
            Debug.Log("Timer Has Ended.You Won" +HasWon.ToString());
            gamePlayScripts.end();

            if (tapCount>highscore)
                highscore = tapCount;
            Debug.Log("High Score is " + highscore);

        }

        // Update the text on the screen every frame
        gamePlayScripts.UpdateText();
        gamePlayScripts.Highscoretext();
        savehighscore();

        // Detect tap and update tap count
        if (!gamePlayScripts.isPaused && Input.GetMouseButtonDown(0))
        {
            tapCount++;
            Debug.Log("Tap Count Detected: " + tapCount);
        }
    }
    public void savehighscore()
    {
        PlayerPrefs.SetInt("High Score",highscore);
    }
    public void gethighscore()
    {
       highscore= PlayerPrefs.GetInt("High Score");
    }
}
