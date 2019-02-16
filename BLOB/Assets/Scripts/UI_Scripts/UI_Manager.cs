using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public GameObject Pause_Menu;


    public void UpdateScore()
    {

    }

    public void PauseGame()
    {
        Pause_Menu.SetActive(true);
    }

    public void UnPauseGame()
    {
        Pause_Menu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
