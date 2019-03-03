using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    private UI_Manager _uiManagerMain;

    void Start()
    {
        _uiManagerMain = GameObject.Find("Canvas_MainMenu").GetComponent<UI_Manager>();

        if (_uiManagerMain != null)
        {
            _uiManagerMain.CloseSettings();
            _uiManagerMain.CloseTutorial();
            _uiManagerMain.CloseCredits();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
