using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDisconnect : MonoBehaviour
{
    private GameObject[] enemies;
    [SerializeField] private float minTimeToDisconnect, maxTimeToDisconnect;
    private float timeToDisconnect;
    [SerializeField] private Transform godTransform;
    [HideInInspector] public bool noEnemiesLeft;

    private void Awake()
    {
        timeToDisconnect = Random.Range(minTimeToDisconnect, maxTimeToDisconnect);
    }

    private void Update()
    {   
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        timeToDisconnect -= Time.deltaTime;
        if (timeToDisconnect <= 0f)
        {
            DisconnectEnemy();
        }
    }

    private void DisconnectEnemy()
    {
        if (enemies.Length == 0)
        {
            noEnemiesLeft  = true;
            return;
        }
        else
        {
            noEnemiesLeft = false;
        }
        int randomEnemy = Random.Range(0, enemies.Length);
        enemies[randomEnemy].transform.SetParent(godTransform, true);
        timeToDisconnect = Random.Range(minTimeToDisconnect, maxTimeToDisconnect);
    }
}
