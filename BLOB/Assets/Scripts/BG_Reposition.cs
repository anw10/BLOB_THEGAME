using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Reposition : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;

    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x;
        
    }

    void repositionBG()
    {
        Vector2 groundOffset = new Vector2(groundHorizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < groundHorizontalLength)
        {
            repositionBG();
        }
        
    }
}
