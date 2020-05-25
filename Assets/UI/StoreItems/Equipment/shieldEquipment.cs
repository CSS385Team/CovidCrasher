using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldEquipment : MonoBehaviour
{
    // Start is called before the first frame update
    public HealthSystem playerHealth;
    public int shieldUnit = 5;
    public GameObject[] player;
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
        playerHealth = player[0].GetComponent<HealthSystem>();
        playerHealth.setShield(shieldUnit);
    }
}
