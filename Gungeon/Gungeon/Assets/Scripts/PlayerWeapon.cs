using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    float maxLookAngle = 70f;
    float minLookAngle = 20f;
    
    //public Animator revolver; //luca added
    //public Animator rayGun; //luca added
    public Animator weapon;

    void Update()
    {
        //mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
        // use this code for hand or gun to angle to target

        Vector2 lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        
        // looking right (degree range is up at 90, straight right at 0, and down at -90)
        if (lookAngle <= 90 && lookAngle >= 70)
        {
            lookAngle = 70f;            
        }
        if (lookAngle <= 110 && lookAngle > 90)
        {
            lookAngle = 110f;
        }
        
        //looking left (degree range is up at 90, straight out at 180/-180, then down at -90)
        if (lookAngle < -90 && lookAngle >= -110)
        {
            lookAngle = -110f;
        }
        if (lookAngle <= -70 && lookAngle >= -90)
        {
            lookAngle = -70f;
        }
        
        else
            transform.rotation = Quaternion.Euler(0f, 0f, lookAngle);


        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D bulletRB = bullet.GetComponent<Rigidbody2D>();
        bulletRB.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        //revolver.SetTrigger("Shoot");

        weapon.SetTrigger("Shoot");
        
    }
}
