using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewHighScore : MonoBehaviour
{
    //private ScoreScript score = GetComponent<ScoreScript>();
    private static int score;
    public int highscore;
    Text newhighscore;

    void Start()
    {
        newhighscore = GetComponent<Text>();
        highscore = PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        score = ScoreScript.scoreValue;
        if (score > highscore)
        {
            newhighscore.text = "New High Score!";
        }
        else
        {
            newhighscore.text = "";
        }
    }
}
