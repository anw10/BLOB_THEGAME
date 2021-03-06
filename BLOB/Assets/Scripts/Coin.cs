﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{


    private Player player;

    [SerializeField]
    private AudioClip _clip;

    private void Start()
    {

        player = GameObject.Find("Player_Blob").GetComponent<Player>();

    }

    void Update()

    {
        float distance = Vector3.Distance(transform.localPosition, player.transform.localPosition);
        if (player.has_magnet == true && distance < 5f) {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, player.transform.localPosition, Time.deltaTime * 10f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.tag == "Player")
        {
            if (player != null)
            {
                ScoreScript.scoreValue += 10;
                AudioSource.PlayClipAtPoint(_clip, Camera.main.transform.position);

            }
            Destroy(this.gameObject);
        }
    }

}
