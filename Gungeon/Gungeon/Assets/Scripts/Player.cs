using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject deathReaction;
    public GameObject gameOver;

    public void TakeDamage (int damage)
    {
        GameObject.Find("Player").GetComponent<HearthSystem>().ChangeHealth(-damage);
        if (PlayerStats.health <= 0)
        {
            Die();
            GameOver();
        }

    }

    void Die ()
    {
        GameObject reaction = Instantiate(deathReaction, transform.position, Quaternion.identity);
        Destroy(reaction, 1.4f);
        Destroy(gameObject);        
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
    }
}
