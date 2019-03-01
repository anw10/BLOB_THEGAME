using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float _speed = 4.0f;

    [SerializeField]
    private float _jumpPower = 13.0f;

    [SerializeField]
    private bool _onGround = false;

    [SerializeField]
    private GameObject _CoinObject;

    [SerializeField]
    private GameObject _trashObject;

    [SerializeField]
    private GameObject _Jump_PowerUp_Object;

    private bool doubleJump = true;

    private bool jump_power_up = false;

    private int _score;

    public int _time;

    public bool has_magnet;

    private SceneSwitch _sceneswitch;




    public Animator player_animator;
    // Start is called before the first frame update 
    void Start()
    {
        _sceneswitch = GetComponent<SceneSwitch>();

        has_magnet = false;

        _time = 100;
        _score = 0;

        transform.position = new Vector3(-6.806f, -0.652f, 0);
        Instantiate(_CoinObject, new Vector3(-5.9f, -0.51f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(-1.3f, -2.549f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(5.6f, -0.3f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(15.27f, 2.6f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(13.92f, 2.6f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(16.79f, 2.6f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(18.31f, 2.6f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(29.25f, -0.38f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(35.8f, -0.38f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(52.59f, 2.9f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(65.23f, 0.96f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(66.62f, 0.96f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(76.22f, -1.38f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(110.74f, 4.71f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(109.27f, 4.7f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(138.51f, 0.78f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(137.17f, 0.85f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(156.23f, 8.62f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(167.65f, 7.63f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(171.8f, 6.58f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(175.66f, 5.41f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(178.94f, 4.59f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(211.23f, 6.81f, 0), Quaternion.identity);
        Instantiate(_CoinObject, new Vector3(212.87f, 6.81f, 0), Quaternion.identity);



        Instantiate(_trashObject, new Vector3(32.35f, -0.38f, 0), Quaternion.identity);
        Instantiate(_trashObject, new Vector3(48.96f, 2.9f, 0), Quaternion.identity);
        Instantiate(_trashObject, new Vector3(70.72f, 0.9f, 0), Quaternion.identity);
        Instantiate(_trashObject, new Vector3(109.62f, 0.55f, 0), Quaternion.identity);
        Instantiate(_trashObject, new Vector3(137.87f, 4.47f, 0), Quaternion.identity);
        Instantiate(_trashObject, new Vector3(139.68f, 4.47f, 0), Quaternion.identity);

        Instantiate(_Jump_PowerUp_Object, new Vector3(80.903f, -1.6314f, 0), Quaternion.identity);
    }



    // Update is called once per frame 
    void Update()
    {
        Movement();

        if (transform.position.y < -8.97)
        {
            _sceneswitch.ToMain();
        }

        _time--;
    }


    /// <summary> 
    /// Movement Method controls the movement of Player_Blob. 
    /// Using RigidBody2D to enable our player to jump.  
    /// </summary> 
    private void Movement()
    {
        transform.Translate(Vector3.right * Time.deltaTime * _speed);

        //Input.touchCount > 0

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Touch touch = Input.GetTouch(0);
            if (jump_power_up == true)
            {
                if (_onGround == true)
                {
                    player_animator.SetBool("IsJumping", true);

                    GetComponent<Rigidbody2D>().AddForce(new Vector3(0, _jumpPower, 0), ForceMode2D.Impulse);
                    _onGround = false;
                }
                else if (doubleJump == true)
                {
                    player_animator.SetBool("IsJumping", false);
                    player_animator.SetBool("IsJumping", true);

                    GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 9, 0), ForceMode2D.Impulse);
                    doubleJump = false;
                }
            }
            else {
                if (_onGround == true)
                {
                    player_animator.SetBool("IsJumping", true);

                    GetComponent<Rigidbody2D>().AddForce(new Vector3(0, _jumpPower, 0), ForceMode2D.Impulse);
                    _onGround = false;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "ground")
        {
            _onGround = true;
            player_animator.SetBool("IsJumping", false);
            doubleJump = true;
        }
        else if (other.tag == "Jump_PowerUp"){
            jump_power_up = true;
        }
        else if (other.tag == "coin") {
            //_score = _score + 10;
            ScoreScript.scoreValue += 10;
            Debug.Log("Score: " + _score);
        }
        else if (other.tag == "magnet") {
            has_magnet = true;
        }



    }

    public void increase_time() {
        _time = _time + 10; //subject to change amount of time.
    }

    public void SpeedStart()
    {
        _speed = 3.0f;
    }

    public void SpeedStop()
    {
        _speed = 0.0f;
    }

    
}   


        
        