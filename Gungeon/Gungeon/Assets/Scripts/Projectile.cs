using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Projectile : MonoBehaviour
{
    public Transform target;
    public Transform firePoint;  // shooting origin for bullet  
    public GameObject bullet;    
    public float strikeTiming = 1f;


    void Start()
    {
        Throw();
    }

    void Throw()
    {

        float xDistance;
        xDistance = target.position.x - firePoint.position.x;

        float yDistance;
        yDistance = target.position.y - firePoint.position.y;

        float fireAngle; // in radians
        fireAngle = Mathf.Atan((yDistance + 4.905f * (strikeTiming * strikeTiming)) / xDistance); //using math from Jesse Mason's video toolbox method
        float totalVelocity = xDistance / (Mathf.Cos(fireAngle) * strikeTiming);

        float xVelocity, yVelocity;
        xVelocity = totalVelocity * Mathf.Cos(fireAngle);
        yVelocity = totalVelocity * Mathf.Sin(fireAngle);

        GameObject bulletInstance = Instantiate(bullet, firePoint.position, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
        Rigidbody2D rigidBody;
        rigidBody = bulletInstance.GetComponent<Rigidbody2D>();

        rigidBody.velocity = new Vector2(xVelocity, yVelocity);
    }
}

