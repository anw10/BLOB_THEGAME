using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver = true;
    public GameObject player;

    private UI_Manager _uiManager;

    private void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UI_Manager>();
        _uiManager.HideOptionsScreen();
    }
    
    //if game over == true
    //if space key pressed
    //spawn player
    //gameOver false

    void Update()
    {
        if (gameOver == true)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Instantiate(player, Vector3.zero, Quaternion.identity);
                gameOver = false;
                _uiManager.HideTitleScreen();
            }

            if (Input.GetKeyDown(KeyCode.O))
            {
                _uiManager.ShowOptionsScreen();
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                _uiManager.HideOptionsScreen();
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
                Debug.Log("Ordered to End Application.");
            }
        }

    }
}
