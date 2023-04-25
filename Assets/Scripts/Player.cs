using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private float moveX;
    [SerializeField] private float speed;
    [SerializeField] private GameObject[] healthBars;
    private int indexOfHealthBar = 2;
    private float health = 3;

    public GameObject loseScreen;
    private void Awake()
    {
        rigidBody2D = this.GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            health -= 1;
            Destroy(healthBars[indexOfHealthBar]);
            indexOfHealthBar -= 1;
            Destroy(other.gameObject);
        }
    }

    private void FixedUpdate()
    {
        moveX = Input.GetAxis("Horizontal");
        rigidBody2D.velocity = new Vector2(moveX,0f) * speed;

        if (health < 1)
        {
            LoserMoment();
        }
    }

    private void LoserMoment()
    {
        Time.timeScale = 0f;
        loseScreen.SetActive(true);
        GameManager.canShoot = false;
    }
}
