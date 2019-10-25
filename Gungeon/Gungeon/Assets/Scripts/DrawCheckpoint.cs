using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCheckpoint : MonoBehaviour
{
    public GameObject[] checkpoint;

    void FixedUpdate()
    {
        checkpoint = GameObject.FindGameObjectsWithTag("Checkpoint");
        if(checkpoint.Length > 1)
        {
            for (int i = 0; i < checkpoint.Length - 1; i++)
            {
                Debug.DrawLine(checkpoint[i].transform.position, checkpoint[i + 1].transform.position, Color.red);
            }
        }
    }
}
