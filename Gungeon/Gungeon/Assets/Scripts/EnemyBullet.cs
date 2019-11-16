using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public int damage = 10;
    public Rigidbody2D rigidBody;
    public Vector2 moveDirection;
    Player target;

    public GameObject hitEffect;

    void Start()
    {
        target = GameObject.FindObjectOfType<Player>();
        moveDirection = (target.transform.position - transform.position).normalized * bulletSpeed;
        rigidBody.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);
        
        //rigidBody.velocity = transform.right * bulletSpeed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Player player = hitInfo.GetComponent<Player>();
        if (player != null)
        {
            player.TakeDamage(damage);
            Destroy(gameObject);
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 5f);
        //Destroy(gameObject, 2f);
    }

}
