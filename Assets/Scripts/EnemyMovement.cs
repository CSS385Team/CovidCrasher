using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Used this YouTube video for help: https://www.youtube.com/watch?v=CeXAiaQOzmY
    /* Functional with WASD and arrow keys.
    Player character moves constantly at top speed,
    and stops as soon as the key is let go.*/
    
	public float speed;
    private Rigidbody2D rb;
    private Vector2 mv;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 mi = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        mv = mi.normalized * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + mv * Time.fixedDeltaTime);
    }
}
