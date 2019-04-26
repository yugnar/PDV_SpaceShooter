﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject meteor;
    public GameObject enemyShip;

    // Start is called before the first frame update
    void Start()
    {
        //Starting in 2 seconds, spawn a meteor in a random position every 3 seconds.
        InvokeRepeating("SpawnMeteor", 2.0f, 3.0f);
        //Starting in 3 seconds, spawn an enemy ship in a random position every 5 seconds.
        InvokeRepeating("SpawnEnemy", 3f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnMeteor()
    {
        GameObject meteorInstance = Instantiate(meteor, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + Random.Range(0.0f, 7.5f)), Quaternion.identity);
    }

    public void SpawnEnemy()
    {
        GameObject enemyInstance = Instantiate(enemyShip, new Vector2(gameObject.transform.position.x, gameObject.transform.position.y + Random.Range(0.0f, 7.5f)), Quaternion.Euler(0,0,-90));
    }
}
