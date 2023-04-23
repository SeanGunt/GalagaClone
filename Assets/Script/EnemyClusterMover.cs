using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClusterMover : MonoBehaviour
{
    private float moveX, initialX;

    private void Awake()
    {
        initialX = this.transform.position.x;
    }
    private void Update()
    {
        moveX = initialX + Mathf.Sin(Time.time * 2);
        this.transform.position = new Vector3(moveX, this.transform.position.y, this.transform.position.z);
    }
}
