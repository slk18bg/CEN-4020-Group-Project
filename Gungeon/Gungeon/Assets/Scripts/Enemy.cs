using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public GameObject rewardPrefab;
    public GameObject deathReaction;
    public bool deathEffect = true;
        
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
        if(deathEffect == true)
        {
            GameObject reaction = Instantiate(deathReaction, transform.position, Quaternion.identity);
            Destroy(reaction, 2f);
        }        
        Destroy(gameObject);
        DropReward();
    } 
    
    private void DropReward()
    {        
        Instantiate(rewardPrefab, transform.position, transform.rotation);
    }
}
