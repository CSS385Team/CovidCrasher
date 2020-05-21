using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoapGrenade : MonoBehaviour
{
    public double delay = 0.8f;
    public GameObject explosionEffect;
    public float radius = 5f;
    bool hasExploded = false;


    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * 10f;
        this.StartCoroutine(DelayAndExplode());
    }

    private void OnCollisionEnter2D(Collision2D collisionData)
    {
        if(collisionData.gameObject.tag == "Enemy")
        {
            Explode();
            hasExploded = true;
        }
    }

    IEnumerator DelayAndExplode()
    {
        yield return new WaitForSeconds(.8f);
        if (!hasExploded)
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
