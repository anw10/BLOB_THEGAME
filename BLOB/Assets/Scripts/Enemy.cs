using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


    private Player player;

    private float _speed;

    private void Start()
    {
        _speed = 5.0f;
        player = GameObject.Find("Player_Blob").GetComponent<Player>();
        float x_position = this.transform.position.x;

    }
    void Update()
    {
        movement();

        enemyDestroyConditions();
    }

    private void enemyDestroyConditions() {

        if (this.transform.position.x < player.transform.position.x - 7f)
        {
            Destroy(this.gameObject);
        }
        else if (this.transform.position.y < -8.97f)
        {
            this.transform.position = new Vector3(this.transform.position.x - 2f, 15f, 0);
        }
    }

    private void  movement()
    {
        float distance = Vector3.Distance(transform.localPosition, player.transform.localPosition);
        if (distance < 20.0f)
        {
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        }
    }

}
