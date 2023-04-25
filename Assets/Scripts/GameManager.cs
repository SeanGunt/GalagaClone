using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool canShoot = true;

    private void Awake()
    {
        canShoot = true;
    }
}
