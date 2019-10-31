using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeLevel : MonoBehaviour
{ 

public string level;

void OnTriggerEnter2D(Collider2D col) 
{
    if (col.CompareTag("Player"))
    {
      
        Debug.Log("Entered trigger");
        Application.LoadLevel(level);
    }
}
}
