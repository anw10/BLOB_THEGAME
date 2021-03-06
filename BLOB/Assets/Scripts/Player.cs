using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public float _speed = 5.0f;

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

    private AudioSource _audioSource;

    public int _time;

    public bool has_magnet;

    private SceneSwitch _sceneswitch;
    private UI_Manager _uimanager;

    [SerializeField]
    private float _vertical_velocity;

    private Rigidbody2D rb; //this is new

    public Animator player_animator;
    // Start is called before the first frame update 
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>(); //this is new
        _sceneswitch = GetComponent<SceneSwitch>();
        _audioSource = GetComponent<AudioSource>();

        _uimanager = GameObject.Find("Canvas_Game").GetComponent<UI_Manager>();

        has_magnet = false;

        TimeScript.timeValue = 80.0f;


        transform.position = new Vector3(-8.806f, -0.652f, 0);




        Instantiate(_Jump_PowerUp_Object, new Vector3(80.903f, -1.6314f, 0), Quaternion.identity);
    }



    // Update is called once per frame 
    void Update()
    {
        Movement();
        play_animation();

        float velocity = transform.position.x;
        Debug.Log("Vertical " + velocity   );

        if (transform.position.y < -8.50)
        {
            kill_player();
        }

        if (transform.position.x > 650)
        {
            win_game();
        }

        TimeScript.timeValue -= Time.deltaTime;
    }

    public void kill_player() {
        Time.timeScale = 0;
        _uimanager.EndGame();
    }

    public void win_game()
    {
        Time.timeScale = 0;
        _uimanager.WinGame();
    }


    /// <summary> 
    /// Movement Method controls the movement of Player_Blob. 
    /// Using RigidBody2D to enable our player to jump.  
    /// </summary> 


    public float jumpRate = 0.25f;
        public float canJump = 0.0f;

    private void Movement()
    {
        transform.Translate(Vector3.right * Time.deltaTime * _speed);
        //Input.touchCount > 0 
        if (Input.touchCount > 0)
        {
            if (Time.time > canJump)
            {
                Touch touch = Input.GetTouch(0);

                if (jump_power_up == true)
                {
                    if (_onGround == true)
                    {

                        GetComponent<Rigidbody2D>().AddForce(new Vector3(0, _jumpPower, 0), ForceMode2D.Impulse);
                        _audioSource.Play();
                        _onGround = false;
                    }
                    else if (doubleJump == true)
                    {
                        GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 9, 0), ForceMode2D.Impulse);
                        _audioSource.Play();
                        doubleJump = false;
                    }
                }
                else
                {
                    if (_onGround == true)
                    {

                        GetComponent<Rigidbody2D>().AddForce(new Vector3(0, _jumpPower, 0), ForceMode2D.Impulse);
                        _audioSource.Play();
                        _onGround = false;
                    }
                }

                canJump = Time.time + jumpRate;
            }
        }
    }

    public void play_animation() {
        if (rb != null)
        {
            _vertical_velocity = (float)Math.Round(rb.velocity.y);
        }
        if (_vertical_velocity > 1f) 
        {
            player_animator.SetFloat("speed", 1.0f);
            player_animator.SetBool("run", false);
        }

        else if (_vertical_velocity < -1f) 
        {
            player_animator.SetFloat("speed", -1.0f);
            player_animator.SetBool("run", false);
        }

        else 
        {
            player_animator.SetBool("run", true);
            player_animator.SetFloat("speed", 0.0f);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "ground")
        {
            _onGround = true;
            doubleJump = true;
        }
        else if (other.tag == "Jump_PowerUp"){
            jump_power_up = true;
        }
        //else if (other.tag == "coin") {
            //_score = _score + 10;
           
            //Debug.Log("Score: " + _score);
        //}
        else if (other.tag == "trashCan")
        {
            increase_time();
        }
        else if (other.tag == "magnet")
        {
            StartCoroutine(MagnetPowerDownRoutine());
        }
        else if (other.tag == "Enemy") {
            kill_player();
        }


    }

    public IEnumerator MagnetPowerDownRoutine()
    {
        yield return new WaitForSeconds(8.0f);
        has_magnet = false;
    }

    public void increase_time() {
        TimeScript.timeValue += 10.0f;
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


        
        