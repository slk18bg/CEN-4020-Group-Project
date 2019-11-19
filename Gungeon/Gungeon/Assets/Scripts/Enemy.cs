using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject gemPrefab;
    public GameObject deathReaction;
    

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        //Instantiate(deathReaction, transform.position, Quaternion.identity);
        Destroy(gameObject);
        GameObject gemdrop = Instantiate(gemPrefab, transform.position, transform.rotation);
    }
}
