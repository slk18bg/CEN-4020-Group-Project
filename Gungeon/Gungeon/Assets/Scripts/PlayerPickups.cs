﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPickups : MonoBehaviour
{

    // objects variables
    //private ref int Money = PlayerStats.money;
   //private int health;

    // text for testing till graphic UI implemented
    public Text moneyText;
    public Text healthText;

    public AudioClip PickupSound;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerStats.money = 0;
        //PlayerStats.health = 3;
        SetMoneyText();
        SetHealthText();
        //GameObject.Find("Player").GetComponent<Player>().health = 3; 

        audioSource = GetComponent<AudioSource>();
    }

 
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))

        {
            Debug.Log("Inside player script pick up coin");
            //SoundManagerScript.PlaySound("CoinPickUp");
            //Destroy(collision.gameObject);
            collision.gameObject.SetActive(false);
            ++PlayerStats.money;
            SetMoneyText();
            audioSource.PlayOneShot(PickupSound, 0.7F);
        }
        else if (collision.CompareTag("Gem"))
        {
            collision.gameObject.SetActive(false);
            PlayerStats.money += 10;
            SetMoneyText();
            audioSource.PlayOneShot(PickupSound, 0.7F);
        }
        else if (collision.CompareTag("Potion"))
        {
            if (PlayerStats.health >= 0 && PlayerStats.health < PlayerStats.maxHealth)
            {
                GameObject.Find("Player").GetComponent<HearthSystem>().ChangeHealth(3);
                collision.gameObject.SetActive(false);
                //++PlayerStats.health;
                SetHealthText();
                audioSource.PlayOneShot(PickupSound, 0.7F);
            }

        }
    }

    private void SetMoneyText()
    {
        moneyText.text = PlayerStats.money.ToString();
        // maybe calling some method here for future stuff
    }

    private void SetHealthText()
    {
        healthText.text = PlayerStats.health.ToString();

    }
}
