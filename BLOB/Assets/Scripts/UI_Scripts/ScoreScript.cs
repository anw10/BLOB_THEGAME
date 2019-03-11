using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int scoreValue;
    public int highscore;
    Text score;

   //private HighScoreScript high_score_script;

    void Start()
    {
        //high_score_script = GetComponents<HighScoreScript>();
        score = GetComponent<Text>();
        scoreValue = 0;
        //highscore = 0;
        highscore = PlayerPrefs.GetInt("highscore");
    }

    void Update()
    {
        score.text = "Score: " + scoreValue;

        //highText.text = "High Score: " + highscore;

        if (scoreValue > highscore)
        {

            PlayerPrefs.SetInt("highscore", scoreValue);
        }
    }

}
