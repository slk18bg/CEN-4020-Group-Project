using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public int health = 100;

    //public GameObject deathReaction;

    public void TakeDamage (int damage)
    {
        //health -= damage;
        GameObject.Find("Player").GetComponent<HearthSystem>().ChangeHealth(-damage);
        if (PlayerStats.health <= 0)
        {
            Die();
        }

    }

    void Die ()
    {
        //Instantiate(deathReaction, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
