using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBlaster : MonoBehaviour
{

    public Rigidbody2D rb;
    private float speed = 10f;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 1f);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
