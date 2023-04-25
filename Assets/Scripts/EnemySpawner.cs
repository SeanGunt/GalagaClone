using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;
    [SerializeField] private RandomDisconnect randomDisconnect;
    private int indexToSpawn = -1;
    public int timesSpawned = 0;
    public GameObject ContinueScreen;

    private void Awake()
    {
        indexToSpawn = -1;
        timesSpawned = 0;
    }

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
        SpawnTracker();
        Instantiate(enemies[indexToSpawn], new Vector3(0f, 2.5f, 0f), Quaternion.identity);

    }

    private void NoMoreEnemies()
    {
        StartCoroutine(EndLevel());
        ContinueScreen.SetActive(true);
        GameManager.canShoot = false;
    }

    IEnumerator EndLevel() 
    {
      yield return new WaitForSeconds(3f);
    }

    public void SpawnTracker()
    {
        timesSpawned += 1;
        if (timesSpawned >= 3)
        NoMoreEnemies();
    }
}
