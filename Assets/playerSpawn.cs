using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpawn : MonoBehaviour
{
    // Start is called before the first frame update
   
    GameObject playerObject;
    GameObject UIObject;
    private Transform player;
    public GameObject playerPrefab;
    public GameObject UIPrefab;

    void Awake()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        UIObject = GameObject.FindGameObjectWithTag("UI");
        playerObject = GameObject.FindGameObjectWithTag("Player");
        UIObject = GameObject.FindGameObjectWithTag("UI");
        playerObject = GameObject.FindGameObjectWithTag("Player");
        UIObject = GameObject.FindGameObjectWithTag("UI");
        playerObject = GameObject.FindGameObjectWithTag("Player");
        UIObject = GameObject.FindGameObjectWithTag("UI");
        if (playerObject == null)
            playerObject = Instantiate(playerPrefab);
        player = playerObject.transform; 
        player.position = gameObject.transform.position;
        if (UIObject == null)
            Instantiate(UIPrefab);
    }

   
}
