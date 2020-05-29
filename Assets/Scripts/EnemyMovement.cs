using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyMovement : MonoBehaviour
{
    // Used this YouTube video for help: https://www.youtube.com/watch?v=CeXAiaQOzmY
    /* Functional with WASD and arrow keys.
    Player character moves constantly at top speed,
    and stops as soon as the key is let go.*/

    public float speed;
    public float lookRadius = 10f;

    private Rigidbody2D rb;
    private Vector2 mv;
    private float tempSpeed;
    private AIPath aiPath;
    private Transform player;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tempSpeed = speed;
        aiPath = GetComponent<AIPath>();
        aiPath.canMove = false;
        aiPath.canSearch = false;
        
        player = GameObject.FindGameObjectWithTag("Player")?.transform;

        // set the player as the target for pathfinding
        GetComponent<AIDestinationSetter>().target = player;
    }

    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player")?.transform;
            if(player == null)
                return;
            // set the player as the target for pathfinding
            GetComponent<AIDestinationSetter>().target = player;
        }

        aiPath.maxSpeed = speed;
        // if enemy is at x distance from player, then start searching/following
        var distance = Vector3.Distance(transform.position, player.position);
        if (distance < lookRadius)
        {
            aiPath.canMove = true;
            aiPath.canSearch = true;
        }
    }

    // Gabe: Funtion inspired by Playground Challenge Code "ConditionArea"
    void OnTriggerStay2D(Collider2D otherCollider)
    {
        if (otherCollider.CompareTag("Mucus"))
        {
            Debug.Log("Collided!");
            this.speed = 2;
        }
    }

    private void OnTriggerExit2D(Collider2D otherCollider)
    {
        if (otherCollider.CompareTag("Mucus"))
        {
            this.speed = tempSpeed;
        }
    }

}
