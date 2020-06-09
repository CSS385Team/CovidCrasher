using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    private float speed = 10f;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;

        // destroy the spike after 2 seconds
        Destroy(gameObject, 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 11)
            Destroy(gameObject);
    }
}
