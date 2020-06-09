using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarTriggerScript : MonoBehaviour
{
    public GameObject bossHealthBar;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            bossHealthBar.SetActive(true);
        }
    }
}
