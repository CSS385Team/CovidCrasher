using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    float lookRadius = 20f;
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        var distance = Vector3.Distance(transform.position, player.position);
        if (distance < lookRadius)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                whereToSpawn = new Vector2(transform.position.x, transform.position.y);
                Instantiate(enemyPrefab, whereToSpawn, Quaternion.identity);
            }
        }   
    }
}
