using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;

    [SerializeField]
    private float _jumpPower = 15.0f;

    // Start is called before the first frame update 
    void Start()
    {
        //transform.position = new Vector3(-7.64f, -3.45f, 0);
    }

    // Update is called once per frame 
    void Update()
    {
        Movement();
    }


    /// <summary> 
    /// Movement Method controls the movement of Player_Blob. 
    /// Using RigidBody2D to enable our player to jump.  
    /// </summary> 
    private void Movement()
    {
        transform.Translate(Vector3.right * Time.deltaTime * _speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector3(0, _jumpPower, 0), ForceMode2D.Impulse);
        }
    }
}
