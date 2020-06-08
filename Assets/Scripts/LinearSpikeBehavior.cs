using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearSpikeBehavior : MonoBehaviour
{

    /* Code inspired by this YouTube video: https://www.youtube.com/watch?v=_Z1t7MNk0c4*/
    
    private float speed = 5;
    private Transform player;
    private Vector2 target;
    private float angleOfTravel;
    private float targetX;
    private float targetY;
    private Vector2 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;

        target = new Vector2(player.position.x, player.position.y);
        
        // Getting angle help from: https://answers.unity.com/questions/161138/deriving-and-angle-from-two-points.html
        angleOfTravel = Mathf.Atan2(gameObject.transform.position.y-player.position.y, gameObject.transform.position.x-player.position.x)/* * Mathf.Deg2Rad*/;/*

        // Getting targeted position help from: https://answers.unity.com/questions/759542/get-coordinate-with-angle-and-distance.html
        targetX = Mathf.Cos(angleOfTravel) * Mathf.Rad2Deg;
        targetY = Mathf.Sin(angleOfTravel) * Mathf.Rad2Deg;
        targetPosition = new Vector2(targetX, targetY);*/

        // Getting help rotating object to the correct direction:
        // https://answers.unity.com/questions/654222/make-sprite-look-at-vector2-in-unity-2d-1.html
        angleOfTravel = angleOfTravel * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angleOfTravel - 270f);
    }

    // Update is called once per frame
    void Update()
    {   

        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y) {
            Destroy(gameObject);
        }

        /*
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, -speed * Time.deltaTime);*/

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
        Destroy(gameObject);
    }
    
}
