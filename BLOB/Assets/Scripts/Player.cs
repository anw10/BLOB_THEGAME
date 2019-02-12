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
    private bool _onGround = false;

    [SerializeField]
    private GameObject _CoinObject;

    public int jumptime = 0;

    public Animator player_animator;
    // Start is called before the first frame update 
    void Start()
    {
        transform.position = new Vector3(-7.88f, 0.22f, 0);
        Instantiate(_CoinObject, new Vector3(-5.9f, 1.3f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(-1.3f, -1.5f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(5.6f, 0.76f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(17.2f, 3.5f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(17.2f, 3.5f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(16.2f, 3.5f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(18.2f, 3.5f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(15.2f, 3.5f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(20.2f, 3.5f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(17.2f, 3.5f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(32.2f, 4.5f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(34.2f, 4.5f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(36.2f, 4.5f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(38.2f, 4.5f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(52.2f, 3.4f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(32.2f, 4.5f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(146.2f, 9.9f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(148.2f, 9.9f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(150.2f, 9.9f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(152.2f, 9.9f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(154.2f, 9.9f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(214.2f, 7.8f, 0), Quaternion.identity);



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
            player_animator.SetBool("IsJumping", true);

            GetComponent<Rigidbody2D>().AddForce(new Vector3(0, _jumpPower, 0), ForceMode2D.Impulse);
            _onGround = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "ground")
        {
            _onGround = true;
            player_animator.SetBool("IsJumping", false);
        }
    }



}   

