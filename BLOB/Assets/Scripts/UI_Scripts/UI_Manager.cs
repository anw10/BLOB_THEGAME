using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public GameObject Background;
    public GameObject Pause_Menu;
    public GameObject Settings_Menu;
    public GameObject Credits_Menu;
    public GameObject Tutorial_Menu;

    private void Start()
    {
        Background.SetActive(true);
        Settings_Menu.SetActive(false);
        Credits_Menu.SetActive(false);
        Tutorial_Menu.SetActive(false);
    }


        public void UpdateScore()
    {

    }


    public void OpenSettings()
    {
        Settings_Menu.SetActive(true);
        Background.SetActive(false);
    }

    public void CloseSettings()
    {
        Settings_Menu.SetActive(false);
        Background.SetActive(true);
    }


    public void PauseGame()
    {
        Pause_Menu.SetActive(true);
        Time.timeScale = 0;
    }

    public void UnPauseGame()
    {
        Pause_Menu.SetActive(false);
        Time.timeScale = 1;
    }


    public void OpenCredits()
    {
        Credits_Menu.SetActive(true);
        Background.SetActive(false);
    }

    public void CloseCredits()
    {
        Credits_Menu.SetActive(false);
        Background.SetActive(true);
    }


    public void OpenTutorial()
    {
        Tutorial_Menu.SetActive(true);
        Background.SetActive(false);
    }

    public void CloseTutorial()
    {
        Tutorial_Menu.SetActive(false);
        Background.SetActive(true);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
