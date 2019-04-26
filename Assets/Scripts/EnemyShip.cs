using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public float destroyTime = 10f;
    public float verticalMovement = 0.08f;

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }


    void Update()
    {
        var position = gameObject.transform.position;
        position.x += -0.1f;
        position.y += verticalMovement;
        if(position.y >= 4)
        {
            //Move down now
            verticalMovement = -0.08f;
        }
        else if(position.y <= -4.1)
        {
            //Move up now
            verticalMovement = 0.08f;
        }
        gameObject.transform.position = position;
    }

    void OnTriggerEnter2D(Collider2D collisionObject)
    {
        if (collisionObject.gameObject.CompareTag("PlayerShip"))
        {
            Destroy(gameObject);
        }
    }
}
