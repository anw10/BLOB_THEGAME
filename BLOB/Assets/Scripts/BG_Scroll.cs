using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Scroll : MonoBehaviour
{
    public Transform target;
    public float bgspeed;

    private Rigidbody2D rigidBody;
    

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2 (bgspeed, 0f);
    }

    void Update()
    {
        transform.position = target.position;
    }
}
