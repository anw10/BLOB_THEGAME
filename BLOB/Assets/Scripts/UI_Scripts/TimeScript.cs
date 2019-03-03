using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public static float timeValue;
    Text time;

    private Player _player;

    // Start is called before the first frame update
    void Start()
    {
        time = GetComponent<Text>();
        _player = GameObject.Find("Player_Blob").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        time.text = "" + Mathf.Round(timeValue);
        //Debug.Log(timeValue);
        if(timeValue <= 0)
        {
            _player.kill_player();
        }
    }
}
