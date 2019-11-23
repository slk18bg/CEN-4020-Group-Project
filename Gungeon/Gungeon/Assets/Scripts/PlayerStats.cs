using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int money = 0;
    // each hearth is 3 integers, maximum of 5 hearths, 4 enabled at the moment
    public static int health = GameObject.Find("Player").GetComponent<HearthSystem>().curHealth;
    public static int maxHealth = GameObject.Find("Player").GetComponent<HearthSystem>().startHearths *3;
    /* // Start is called before the first frame update
     void Start()
     {

     }

     // Update is called once per frame
     void Update()
     {

     }
     */
}
