using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Camera : MonoBehaviour
{
    public Transform target;

    public float smoothS = 0.125f;

     void LateUpdate()
    {
        if (transform.position.y > -8.5)
        {
            transform.position = target.position + new Vector3(0,2,0);
        }
    }
}
