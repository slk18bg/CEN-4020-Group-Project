using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aiPath;

    void Update()
    {
        if (aiPath.desiredVelocity.x <= 0.01f) //if x speed is moving right then icon faces right
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if(aiPath.desiredVelocity.x >= -0.01f) //if x speed is moving left, flip enemy facing direction to left
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }        
    }
}
