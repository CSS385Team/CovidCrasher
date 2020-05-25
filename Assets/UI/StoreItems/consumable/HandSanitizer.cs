using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSanitizer : MonoBehaviour
{
    GameObject player;
    public GameObject handSanitizerShield;
    private float shieldTime = 3f; 
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player")[0];
    }

    private void OnDestroy()
    {
        GameObject shield = Instantiate(handSanitizerShield, player.transform);
        player.GetComponent<HealthSystem>().setGracePeriod(shieldTime);
        Destroy(shield, shieldTime);
    }
}
