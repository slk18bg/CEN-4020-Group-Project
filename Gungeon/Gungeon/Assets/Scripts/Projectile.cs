using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour
{
    [SerializeField]
    private Transform weaponTip;

    [SerializeField]
    private Transform bullet;

    private Transform playerTarget;
    private Vector2 directionToFire;
    private float angleToFire;


    void Update()
    {
        directionToFire = Camera.main.ScreenToWorldPoint(playerTarget) - transform.position;
        angleToFire = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angleToFire - 90f);

        //set to fire after certain time delay or at waypoints

    }
}

