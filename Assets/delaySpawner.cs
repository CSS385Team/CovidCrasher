using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delaySpawner : MonoBehaviour
{
    public float delay = 6;
    public GameObject spawner;

    void Start()
    {
        delay = 6f;
        Invoke("enableSpawner", delay);
    }

    public void enableSpawner()
    {
        spawner.SetActive(true);
    }
}
