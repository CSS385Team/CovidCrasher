using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoapGrenade : MonoBehaviour
{
    public float delay = 3f;
    public GameObject explosionEffect;
    public float radius = 10f;
    float countdown;
    bool hasExploded = false;


    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && hasExploded == false)
        {
            Explode();
            hasExploded = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collisionData)
    {
        if(collisionData.gameObject.tag == "Enemy")
        {
            Explode();
            hasExploded = true;
        }
    }

    void Explode()
    {
        //show effect
        var explosion = Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(explosion, 2);

        //get nearby object
        var colliders = Physics2D.OverlapCircleAll(transform.position, radius);
        Debug.Log("Colliders Found " + colliders.Length);
        foreach (var nearbyObject in colliders)
        {
            var enemyTag = nearbyObject.gameObject.tag;
            if (enemyTag == "Enemy")
            {
                Destroy(nearbyObject.gameObject);
                Debug.Log("destroyed  " + nearbyObject.tag);
            }
        }

        //remove grenade
        Destroy(gameObject);
    }
}
