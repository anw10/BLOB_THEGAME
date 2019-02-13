using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public GameObject Main_Menu;
    public GameObject Options_Menu;


    public void UpdateScore()
    {

    }

    public void ShowMainMenu()
    {
        Main_Menu.SetActive(true);
    }

    public void HideMainMenu()
    {
        Main_Menu.SetActive(false);
    }

    public void ShowOptionsMenu()
    {
        Options_Menu.SetActive(true);
    }

    public void HideOptionsMenu()
    {
        Options_Menu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
