using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public GameObject Title;
    public GameObject Play_Button;
    public GameObject Options_Button;

    public GameObject Options_Screen;


    public void UpdateScore()
    {

    }

    public void ShowTitleScreen()
    {
        Title.SetActive(true);
        Play_Button.SetActive(true);
        Options_Button.SetActive(true);
    }

    public void HideTitleScreen()
    {
        Title.SetActive(false);
        Play_Button.SetActive(false);
        Options_Button.SetActive(false);
    }

    public void ShowOptionsScreen()
    {
        Options_Screen.SetActive(true);
    }

    public void HideOptionsScreen()
    {
        Options_Screen.SetActive(false);
    }
}
