using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpriteChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private GameObject[] enemies;
    [SerializeField] private Sprite[] enemySprites;

    private void Awake()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
        {
            ChangeSprites(0,2);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2))
        {
            ChangeSprites(2,4);
        }
    }

    private void ChangeSprites(int randomNum1, int randomNum2)
    {
        foreach (GameObject enemy in enemies)
        {
            Debug.Log("Scene 1");
            int randomNum = Random.Range(randomNum1,randomNum2);
            spriteRenderer = enemy.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = enemySprites[randomNum];
        }
    }

}
