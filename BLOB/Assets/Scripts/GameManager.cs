using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver = true;
    private Player player;

    private UI_Manager _uiManager;
    

    private void Start()
    {
        _uiManager = GameObject.Find("Canvas_Game").GetComponent<UI_Manager>();

        _uiManager.UnPauseGame();
        _uiManager.CloseSettings();


        player = GameObject.Find("Player_Blob").GetComponent<Player>();

 
    }
    
    //if game over == true
    //if space key pressed
    //spawn player
    //gameOver false

    void Update()
    {

        /*
        if (gameOver == true)
        {
            
            if (Input.GetKeyDown(KeyCode.P))
            {

                //Instantiate(player, new Vector3(-7.88f, 5.22f, 0), Quaternion.identity);
                player.SpeedStart();
                gameOver = false;
                _uiManager.HideMainMenu();
            }

            if (Input.GetKeyDown(KeyCode.O))
            {
                _uiManager.ShowOptionsMenu();
                _uiManager.HideMainMenu();
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                _uiManager.HideOptionsMenu();
                _uiManager.ShowMainMenu();
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                Application.Quit();
                Debug.Log("Ordered to End Application.");
            }

        }
        */

    }
}
