using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target;

    public float smoothS = 0.125f;
    public Vector3 offset;

     void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
