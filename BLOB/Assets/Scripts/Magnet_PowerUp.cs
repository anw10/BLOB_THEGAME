using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet_PowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    //private Player player;

    void Start()
    {
        //player = GameObject.Find("Player_Blob").GetComponent<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {

            Destroy(this.gameObject);
        }
    }
}
