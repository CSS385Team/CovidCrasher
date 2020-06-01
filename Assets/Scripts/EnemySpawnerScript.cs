using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemySpawnerScript : MonoBehaviour
{
    public GameObject enemyPrefab;
    Vector2 whereToSpawn;
    public float nearSpawnRate = 1f;
    public float farSpawnRate = 3f;

    private float spawnRate;
    float nextSpawn = 0.0f;
    public float lookRadius = 20f;
    private Transform player;


    // Start is called before the first frame update
    void Start()
    {
       // gameObject.SetActive(false);
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
            spawnRate = nearSpawnRate;
        }
        else
        {
            spawnRate = farSpawnRate;
        }

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            whereToSpawn = new Vector2(transform.position.x, transform.position.y);
            var enemy = Instantiate(enemyPrefab, whereToSpawn, Quaternion.identity);
            enemy.GetComponent<EnemyMovement>().ChasePlayer();
        }
    }
}
