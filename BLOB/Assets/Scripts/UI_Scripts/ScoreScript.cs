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

        Debug.Log("IS this working " + highscore);

    }

    void Update()
    {
        score.text = "Score: " + scoreValue;
        if(scoreValue > highscore)
        {
            PlayerPrefs.SetInt("highscore", scoreValue);
        }


    }

}
