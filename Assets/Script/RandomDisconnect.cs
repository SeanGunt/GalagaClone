using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDisconnect : MonoBehaviour
{
    private GameObject[] enemies;
    [SerializeField] private float timeToDisconnect;
    [SerializeField] private Transform godTransform;

    private void Awake()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    private void Update()
    {   
        timeToDisconnect -= Time.deltaTime;
        if (timeToDisconnect <= 0f)
        {
            DisconnectEnemy();
        }
    }

    private void DisconnectEnemy()
    {
        for (int i = 0; i < 6; i++)
        {
            int randomNum = Random.Range(0, 6);
            if (randomNum == 0)
            {
                int randomEnemy = Random.Range(0, enemies.Length);
                enemies[randomEnemy].transform.SetParent(godTransform, true);
            }
        }   
    }
}
