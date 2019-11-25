using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxItem : MonoBehaviour
{
    //public Transform spawnPoint;
    public GameObject item;
    private bool broken;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !broken)
        {
            broken = true;
            GetComponent<Animator>().SetTrigger("break");
            item.SetActive(true);
        }
    }
}