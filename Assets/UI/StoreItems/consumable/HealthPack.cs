using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public HealthSystem playerHealth;
    public GameObject[] player;
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
        playerHealth = player[0].GetComponent<HealthSystem>();
    }
    void OnDestroy()
    {
        Debug.Log("Becoming Invisible");
        playerHealth.ModifyHealth(1);

    }
}
