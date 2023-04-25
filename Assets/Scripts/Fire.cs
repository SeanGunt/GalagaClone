using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private GameObject bullet, bulletSpawnPoint;
    private AudioSource audioSource;
    [SerializeField] private AudioClip fireSound;

    private void Awake()
    {
        audioSource = this.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && GameManager.canShoot && !PauseScreen.GamePaused)
        {
            audioSource.PlayOneShot(fireSound);
            Instantiate(bullet, bulletSpawnPoint.transform.position, Quaternion.identity);
        }
    }
}
