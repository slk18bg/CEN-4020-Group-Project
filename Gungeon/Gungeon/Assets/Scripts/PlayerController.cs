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

   /* private void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 5)
            winText.text = "You Win!";
    }*/
}
