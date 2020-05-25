using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleGunBehavior : MonoBehaviour {
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gameManager = GameObject.FindGameObjectsWithTag("Weapon");
        gameManager[0].GetComponent<Weapon>().equipTripleShot();
    }

}
