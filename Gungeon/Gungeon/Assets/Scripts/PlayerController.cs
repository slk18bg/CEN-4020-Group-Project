using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    //public float bulletBaseSpeed = 1.0f;

    Vector2 movement;

    private int count;
    Rigidbody2D rb2d;
    public Animator animator;
    public Vector3 mousePos;
    public GameObject crosshair;

    public bool endOfAiming;
    public bool isAiming;

    //public GameObject bulletPrefab;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        //winText.text = "";
        //SetCountText();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        mousePos = Input.mousePosition;
        endOfAiming = Input.GetButtonUp("Fire1");
        isAiming = Input.GetButton("Fire1");

        Aim();
        Shoot();
    }

    private void FixedUpdate()
    {

        rb2d.MovePosition(rb2d.position + movement * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);
            count++;
            //SetCountText();
        }
    }

    void Aim()
    {
        if (movement != Vector2.zero)
        {
            crosshair.transform.localPosition = mousePos;
        }
    }

    void Shoot()
    {
        Vector2 shootDirection = crosshair.transform.localPosition;
        shootDirection.Normalize();

        /*
        if(endOfAiming)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * bulletBaseSpeed;
            bullet.transform.Rotate(0, 0, Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg);
            Destroy(bullet, 2.0f);
        }
        */
    }
}
