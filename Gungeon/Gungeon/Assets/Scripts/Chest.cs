using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public Animator chest;
    public GameObject[] objects;
    public Transform spawnPoint;
    private GameObject item;
    private bool chestOpened;
    private float Timer = 10;
    

    private void Update()
    {
        Timer -= Time.deltaTime;
        if ((Timer <= 0) && (PlayerStats.money < ChangeLevel.currentLevelChangeMoney))
        {
            //GetComponent<Animator>().SetTrigger("ItemReady");
            chest.SetBool("ItemReady", true);
        }
        else
            chest.SetBool("ItemReady", false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag ("Player") && (Timer <= 0) && (PlayerStats.money < ChangeLevel.currentLevelChangeMoney))  //&& ((Timer - Time.deltaTime) <= 0) //&& !chestOpened)
        {
            //chestOpened = true;
            //GetComponent<Animator>().SetBool("open",true);
            chest.SetBool("open", true);
            chest.SetBool("ItemReady", false);
            item = Instantiate(objects[Random.Range(0, objects.Length)], spawnPoint.position, spawnPoint.rotation) as GameObject;
            Timer = 10;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(item);
            //GetComponent<Animator>().SetBool("open", false);
            chest.SetBool("open", false);
        }
    }
}
