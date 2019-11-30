using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public GameObject deathReaction;

    public void TakeDamage (int damage)
    {
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
