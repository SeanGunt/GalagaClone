using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopBackgroundMusic : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    private void Awake()
    {
        audioSource.Stop();
    }
    
}
