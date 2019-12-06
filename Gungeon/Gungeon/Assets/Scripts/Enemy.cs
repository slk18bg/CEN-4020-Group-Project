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

    // Game Win functionality written by Sheikh Khaled
    public GameObject GameWin;
    public static bool GamePaused = false;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
            GameWon();
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

    public void GameWon()
    {
        GameWin.SetActive(true); // enables pause menu
        Time.timeScale = 0f; // freeze time
        GamePaused = true;
    }
}
