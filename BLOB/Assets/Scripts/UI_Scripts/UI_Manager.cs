using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public GameObject Background;
    public GameObject Pause_Menu;
    public GameObject Settings_Menu;


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


    public void QuitGame()
    {
        Application.Quit();
    }
}
