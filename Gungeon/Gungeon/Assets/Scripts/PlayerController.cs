using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Vector2 movement;

    private int count;
    Rigidbody2D rb2d;
    public Animator animator;
    public Vector2 mousePos;
    public GameObject crosshair;

    public bool endOfAiming;
    public bool isAiming;

    public Camera camera;

    

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        count = 0;
        
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
        
        //endOfAiming = Input.GetButtonUp("Fire1");
        isAiming = Input.GetButton("Fire1");

        Aim();
        
    }

    private void FixedUpdate()
    {

        rb2d.MovePosition(rb2d.position + movement * speed * Time.fixedDeltaTime);
                
        
        
        // ensure that player is facing mouse aim
        if (rb2d.transform.position.x > mousePos.x)
        {
            rb2d.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            rb2d.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        
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
    /*
    void Shoot()
    {

        Vector2 shootDirection = crosshair.transform.localPosition;
        shootDirection.Normalize();

        
        if (endOfAiming)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDirection * bulletBaseSpeed;
            bullet.transform.Rotate(0, 0, Mathf.Atan2(shootDirection.y, shootDirection.x) * Mathf.Rad2Deg);
            Destroy(bullet, 2.0f);
            
        }
        
    }
    */
}
