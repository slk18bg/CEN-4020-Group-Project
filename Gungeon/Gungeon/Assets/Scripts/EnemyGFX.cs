using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public Transform targetPlayer;

    public AIPath aiPath;

    void Update()
    {
        /*
        if (aiPath.desiredVelocity.x <= 0.01f) //if x speed is moving right then icon faces right
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if(aiPath.desiredVelocity.x >= -0.01f) //if x speed is moving left, flip enemy facing direction to left
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        */
        // make sure enemy is always facing player
        if (transform.position.x > targetPlayer.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
