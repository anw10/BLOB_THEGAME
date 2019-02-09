using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Scroll : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2 (1.5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
