﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    //public GameObject gun;
    public Animator revolver; //luca added
    public Animator rayGun; //luca added
    void Update()
    {
        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
        // use this code for hand or gun to angle to target

        Vector2 lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        if(lookAngle <= 80f || lookAngle >= -80f)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, lookAngle);
        }
        

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        revolver.SetTrigger("Shoot");

        rayGun.SetTrigger("Shoot");



        //daniels stuff
        //rb.velocity = shootDirection * bulletForce;
        //bullet.transform.Rotate(0, 0, Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg);
        //Destroy(bullet, 2.0f);
    }
}
