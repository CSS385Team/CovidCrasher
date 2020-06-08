using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Gabe: edited code from "HealthModification" specifically for the linear Spikes

public class LinearSpikeHealthModBehaviour : MonoBehaviour
{
    public bool destroyWhenActivated = false;
    public int healthChange = -1;
    public string targetTag = "";

    // This function gets called everytime this object collides with another
    private void OnCollisionEnter2D(Collision2D collisionData)
    {
        OnTriggerEnter2D(collisionData.collider);
    }

    private void OnTriggerEnter2D(Collider2D colliderData)
    {
        HealthSystem healthScript = colliderData.gameObject.GetComponent<HealthSystem>();

        if (healthScript != null)
        {
            if (targetTag == colliderData.gameObject.tag)
            {
                // subtract health from the player
                healthScript.ModifyHealth(healthChange);
            }

            if (destroyWhenActivated && colliderData.gameObject.tag != "Enemy")
            {
                Destroy(this.gameObject);

            }
        }
    }
}
