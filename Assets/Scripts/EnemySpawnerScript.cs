﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float nearSpawnRate = 1f;
    public float farSpawnRate = 3f;
    public bool activeOnStart = false;

    private float spawnRate;
    float nextSpawn = 0.0f;
    public float lookRadius = 20f;
    private Transform player;
    private bool triggerOn= true;


    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(activeOnStart);
    }


    // Update is called once per frame
    void Update()
    {
        if (triggerOn == false)
        {
            return;
        }
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player")?.transform;
            if (player == null)
                return;
        }

        var distance = Vector3.Distance(transform.position, player.position);
        if (distance < lookRadius)
        {
            spawnRate = nearSpawnRate;
        }
        else
        {
            spawnRate = farSpawnRate;
        }

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            var whereToSpawn = new Vector2(transform.position.x, transform.position.y);
            var enemy = Instantiate(enemyPrefab, whereToSpawn, Quaternion.identity);
            enemy.GetComponent<EnemyMovement>().ChasePlayer();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            triggerOn = false;
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            triggerOn = true;
        }
    }
}
