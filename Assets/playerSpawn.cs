using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpawn : MonoBehaviour
{
    // Start is called before the first frame update
   
    GameObject playerObject;
    GameObject UIObject;
    GameObject BGM;
    private Transform player;
    public GameObject playerPrefab;
    public GameObject UIPrefab;
    public GameObject LevelMusicPrefab;

    void Awake()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        UIObject = GameObject.FindGameObjectWithTag("UI");
        BGM = GameObject.FindGameObjectWithTag("Music");
        playerObject = GameObject.FindGameObjectWithTag("Player");
        UIObject = GameObject.FindGameObjectWithTag("UI");
        BGM = GameObject.FindGameObjectWithTag("Music");
        playerObject = GameObject.FindGameObjectWithTag("Player");
        UIObject = GameObject.FindGameObjectWithTag("UI");
        BGM = GameObject.FindGameObjectWithTag("Music");
        playerObject = GameObject.FindGameObjectWithTag("Player");
        UIObject = GameObject.FindGameObjectWithTag("UI");
        BGM = GameObject.FindGameObjectWithTag("Music");
        if (playerObject == null)
            playerObject = Instantiate(playerPrefab);
        else
            Debug.Log("Player exist");
        player = playerObject.transform; 
        player.position = gameObject.transform.position;
        if (UIObject == null)
            UIObject = Instantiate(UIPrefab);
        else
            Debug.Log("UI exist");
        if (BGM == null)
        {
            BGM = Instantiate(LevelMusicPrefab);
        }

    }

    public GameObject getPlayer()
    {
        return playerObject;
    }

    public GameObject getUIr()
    {
        return UIObject;
    }


}
