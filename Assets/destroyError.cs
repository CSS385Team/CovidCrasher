using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyError : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        if (GameObject.FindGameObjectWithTag("UI") != null)
            Destroy(GameObject.FindGameObjectWithTag("UI"));
        if (GameObject.FindGameObjectWithTag("Music") != null)
            Destroy(GameObject.FindGameObjectWithTag("Music"));

        if (GameObject.FindGameObjectWithTag("Player") != null)
            Destroy(GameObject.FindGameObjectWithTag("Player"));
        if (GameObject.FindGameObjectWithTag("UI") != null)
            Destroy(GameObject.FindGameObjectWithTag("UI"));
        if (GameObject.FindGameObjectWithTag("Music") != null)
            Destroy(GameObject.FindGameObjectWithTag("Music"));

        if (GameObject.FindGameObjectWithTag("Player") != null)
            Destroy(GameObject.FindGameObjectWithTag("Player"));
        if (GameObject.FindGameObjectWithTag("UI") != null)
            Destroy(GameObject.FindGameObjectWithTag("UI"));
        if (GameObject.FindGameObjectWithTag("Music") != null)
            Destroy(GameObject.FindGameObjectWithTag("Music"));


        if (GameObject.Find("DoctorPlayer(Clone)") != null)
            Destroy(GameObject.Find("DoctorPlayer(Clone)"));
        if (GameObject.Find("UI(Clone)") != null)
            Destroy(GameObject.Find("UI(Clone)"));
        if (GameObject.Find("LevelMusic(Clone)") != null)
            Destroy(GameObject.Find("LevelMusic(Clone)"));
    }
    
    
}
