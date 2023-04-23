using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private float moveX;
    [SerializeField] private float speed;
    private void Awake()
    {
        rigidBody2D = this.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        rigidBody2D.velocity = new Vector2(moveX,0f) * speed;
    }
}
