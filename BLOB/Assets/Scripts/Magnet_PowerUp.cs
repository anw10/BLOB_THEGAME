using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet_PowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
