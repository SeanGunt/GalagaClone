using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    [SerializeField] private AudioClip deathSound;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            AudioSource.PlayClipAtPoint(deathSound, this.transform.position);
            Destroy(this.gameObject);
        }
    }
}
