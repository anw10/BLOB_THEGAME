using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
    public void ToMain()
    {
        SceneManager.LoadScene(0);
    }

    public void ToGame ()
    {
        SceneManager.LoadScene(1);
    }

    public void ToSettings ()
    {
        SceneManager.LoadScene(2);
    }
}
