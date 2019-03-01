using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public static float timeValue;
    Text time;

    // Start is called before the first frame update
    void Start()
    {
        time = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        time.text = "" + Mathf.Round(timeValue);
        //Debug.Log(timeValue);
    }
}
