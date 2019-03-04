using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    //private ScoreScript _scoreScript;

    //public static int scoreValue;
    //public int highscore;
    public int highscore;
    Text highText;
    
    void Start()
    {
        highText = GetComponent<Text>();
        highscore = PlayerPrefs.GetInt("highscore");
        highText.text = "High Score: " + highscore;
        
        
        //_scoreScript = GameObject.Find("Score").GetComponent<ScoreScript>;
        //scoreValue = _scoreScript.scoreValue;

        //highText = GetComponent<Text>();
        //highscore = PlayerPrefs.GetInt("highscore");
    }

    void Update()
    {
        /*highText.text = "High Score: " + highscore;

        if (scoreValue > highscore)
        {
            PlayerPrefs.SetInt("highscore", scoreValue);
        }*/
    }
}
