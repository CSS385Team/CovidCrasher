using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpawn : MonoBehaviour
{
    // Start is called before the first frame update
   
    GameObject gameObjectToMove;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        player.position = gameObject.transform.position;
    }

   
}
