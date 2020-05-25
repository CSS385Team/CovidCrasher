using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClickerBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gameManager = GameObject.FindGameObjectsWithTag("GameController");
        gameManager[0].GetComponent<GameControlScript>().oneMoreAutoClicker(); 
    }
}
