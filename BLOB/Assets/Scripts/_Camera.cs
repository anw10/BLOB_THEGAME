using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Camera : MonoBehaviour
{
    public Transform target;

    public float smoothS = 0.125f;

     void FixedUpdate()
    {
        transform.position = target.position;
      
    }
}
