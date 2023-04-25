using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMover : MonoBehaviour
{
    public float speed = 4f;
    private Vector3 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    
    void FixedUpdate()
    {
        transform.Translate(Vector3.down*speed*Time.deltaTime);

        if (transform.position.y < -14.0 )
        {
            transform.position = startPosition;
    }
}
}
