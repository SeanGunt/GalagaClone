using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    private bool chasingPlayer;
    private GameObject player;
    [SerializeField] private float speed;
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTransformParentChanged()
    {
        Debug.Log(this.gameObject.name);
        chasingPlayer = true;
    }

    private void Update()
    {
        if (chasingPlayer)
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, Time.deltaTime * speed);
        }
    }
}
