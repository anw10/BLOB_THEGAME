using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue;
    public int highscore;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
        scoreValue = 0;

        highscore = PlayerPrefs.GetInt("highscore");
    }

    void Update()
    {
        score.text = "Score: " + scoreValue;

        //highText.text = "High Score: " + highscore;

        if (scoreValue > highscore)
        {
            PlayerPrefs.SetInt("highscore", scoreValue);
            //newhighscore.text = "New High Score!";

        }
    }

}
