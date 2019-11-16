using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float fireRate;
    float nextFire;

    private void Start()
    {
        fireRate = 3f;
        nextFire = Time.time;
    }

    void Update()
    {
        CheckIfTimeToFire();

        /*
        if (Input.GetButtonDown("Fire2"))
        {
            Shoot();
        }
        */
    }

    void CheckIfTimeToFire()
    {
        if(Time.time > nextFire)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            nextFire = Time.time + fireRate;
        }
    }

    /*
    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
    */
}
