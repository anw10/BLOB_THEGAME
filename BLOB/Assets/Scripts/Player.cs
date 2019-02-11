using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;

    [SerializeField]
    private float _jumpPower = 15.0f;

    [SerializeField]
    private bool _onGround = true;

    [SerializeField]
    private GameObject _CoinObject;
    // Start is called before the first frame update 
    void Start()
    {
        transform.position = new Vector3(-7.88f, 0.22f, 0);
        Instantiate(_CoinObject, new Vector3(-5.9f, 1.3f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(-1.3f, -1.5f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(5.6f, 0.76f, 0), Quaternion.identity);
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

        if (Input.GetKeyDown(KeyCode.Space) && _onGround == true)
        {

            GetComponent<Rigidbody2D>().AddForce(new Vector3(0, _jumpPower, 0), ForceMode2D.Impulse);
            //_onGround = false;
        }
    }



}   

