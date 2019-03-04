using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public GameObject Background;
    public GameObject Settings_Menu;
    public GameObject Credits_Menu;
    public GameObject Tutorial_Menu;

    public GameObject Main_Canvas;
    public GameObject Pause_Menu;
    public GameObject End_Screen;
    public GameObject Win_Screen;




    [SerializeField]
    private AudioClip _clip;



    public void PauseGame()
    {
        Pause_Menu.SetActive(true);
        Time.timeScale = 0;
        Main_Canvas.SetActive(false);
    }

    public void UnPauseGame()
    {
        Pause_Menu.SetActive(false);
        Time.timeScale = 1;
        Main_Canvas.SetActive(true);
    }

    public void StartGame()
    {
        End_Screen.SetActive(false);
        Win_Screen.SetActive(false);
    }

    public void EndGame()
    {
        End_Screen.SetActive(true);
        Main_Canvas.SetActive(false);
    }

    public void WinGame()
    {
        Win_Screen.SetActive(true);
        Main_Canvas.SetActive(false);
    }

    public void playClick()
    {
        AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position);
    }

    public void OpenMain()
    {
        Background.SetActive(true);
    }

    public void CloseMain()
    {
        Background.SetActive(false);
    }

    public void OpenSettings()
    {
        Settings_Menu.SetActive(true);
    }

    public void CloseSettings()
    {
        Settings_Menu.SetActive(false);
    }


    public void OpenCredits()
    {
        Credits_Menu.SetActive(true);
    }

    public void CloseCredits()
    {
        Credits_Menu.SetActive(false);
    }


    public void OpenTutorial()
    {
        Tutorial_Menu.SetActive(true);

    }

    public void CloseTutorial()
    {
        Tutorial_Menu.SetActive(false);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
