﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBlaster : MonoBehaviour
{

    public Rigidbody2D rb;
    private float speed = 10f;
    private float time;
    public bool tripleShot = false;
    // Start is called before the first frame update
    void Start()
    {
        if(tripleShot)
        {
            this.gameObject.transform.localScale = new Vector3(transform.localScale.x/2f, transform.localScale.y/2f, transform.localScale.z/2f);
        }
        time = 1f;
        rb.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, time);
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}