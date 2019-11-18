using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    float playerWidthOffset = .8f;
    Vector2 mousePos;

    //public Animator revolver; //luca added
    //public Animator rayGun; //luca added
    public Animator weapon;

    void Update()
    {

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        AimAtMouse();

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void AimAtMouse()
    {
        Vector2 lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        
        
        // looking right 
        if (transform.position.x < mousePos.x)
        {
            if (lookAngle >= 70)
            {
                lookAngle = 70f;
            }
            if (lookAngle <= -70)
            {
                lookAngle = -70f;
            }            
        }

        //looking left
        /*
        if (transform.position.x > mousePos.x)
        {
            if (lookAngle <= 110)
            {
                lookAngle = 110f;                
            }
            if (lookAngle >= -110)
            {
                lookAngle = -110f;                
            }            
        } 
        */
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle);
        
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
