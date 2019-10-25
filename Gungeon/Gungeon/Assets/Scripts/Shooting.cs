using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;
    public float speed;

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Vector2 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        //rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        rb.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
    }
}
