using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{

    private UI_Manager _uiManagerGame;


    void Start()
    {
        _uiManagerGame = GameObject.Find("Canvas_Game").GetComponent<UI_Manager>();

        if (_uiManagerGame != null)
        {
            _uiManagerGame.UnPauseGame();
            _uiManagerGame.StartGame();
        }
    }

    void Update()
    {

    }
}