using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Play;
    public GameObject Settings;
    public GameObject HowToPlay;
    public GameObject Credits;
    public Text playername;

    private void Start()
    {
        MainMenu.SetActive(true);
        Play.SetActive(true);
        Settings.SetActive(true);
        HowToPlay.SetActive(true);
        Credits.SetActive(true);
        Debug.Log("Main Menu Shown");
        playername.text = "Abdullah";
        GameManager.highscore = 30000;
    }

    public void Settingbtn()
    {
        MainMenu.SetActive(false);
        Settings.SetActive(true);
        Debug.Log("Settings Called");
    }

    public void Playbtn()
    {
        MainMenu.SetActive(false);
        Play.SetActive(true);
        Debug.Log("Play Called");
    }

    public void HowToPlaybtn()
    {
        MainMenu.SetActive(false);
        HowToPlay.SetActive(true);
        Debug.Log("How To Play Called");
    }

    public void Creditbtn()
    {
        MainMenu.SetActive(false);
        Credits.SetActive(true);
        Debug.Log("Credits Called");
    }
    public void PlayBtnClicked()
    {
        SceneManager.LoadScene(1);
    }
}
