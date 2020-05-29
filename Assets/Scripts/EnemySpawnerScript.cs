using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject playerSpawner;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    float lookRadius = 20f;
    private Transform player;


    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player")?.transform;
            if (player == null)
                return;
        }

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
