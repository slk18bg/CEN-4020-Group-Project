using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCheckpoint : MonoBehaviour
{
    GameObject objectGenerated;
    public float waitTime = 0.2f;

    void FixedUpdate()
    {
        objectGenerated = new GameObject("Checkpoint");
        objectGenerated.tag = "Checkpoint";
        objectGenerated.transform.position = this.transform.position;
    }
    void Start()
    {
        StartCoroutine(DrawPath(waitTime));
    }

    IEnumerator DrawPath(float timeRate)
    {
        while (true)
        {
            objectGenerated = new GameObject("Checkpoint");
            objectGenerated.tag = "Checkpoint";
            objectGenerated.transform.position = this.transform.position;
            yield return new WaitForSeconds(timeRate);
        }
    }
}
