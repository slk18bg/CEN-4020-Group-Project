using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject deathReaction;

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
        GameObject reaction = Instantiate(deathReaction, transform.position, Quaternion.identity);
        Destroy(reaction, 1.4f);
        Destroy(gameObject);        
    }
}
