using UnityEngine;
using System.Collections;

public class HealthModification : MonoBehaviour {

    public bool destroyWhenActivated = false;
    public int healthChange = -1;
    public string targetTag = "";

    private void Start()
    {
        targetTag = gameObject.tag;
    }

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
            if (targetTag != colliderData.gameObject.tag)
            {
                // subtract health from the player
                healthScript.ModifyHealth(healthChange);
            }

            if (destroyWhenActivated)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
