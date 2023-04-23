using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private RandomDisconnect randomDisconnect;
    private int indexToSpawn = -1;

    private void Update()
    {
        if (randomDisconnect.noEnemiesLeft)
        {
            SpawnWave();
        }
    }

    private void SpawnWave()
    {
        indexToSpawn += 1;
        Instantiate(enemies[indexToSpawn], new Vector3(0f, 2.5f, 0f), Quaternion.identity);
    }
}
