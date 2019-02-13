using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Scroll : MonoBehaviour
{
    public Transform target;

    private Rigidbody2D rigidBody;
    public float bgspeed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2 (bgspeed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position;
    }
}
