﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float destroyTime = 10f;

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }


    void Update()
    {
        var position = gameObject.transform.position;
        position.x += -0.12f;
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
