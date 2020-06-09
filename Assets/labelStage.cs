using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class labelStage : MonoBehaviour
{
    string[] StageName = {"Nasal Cavity", "Esophagus", "Lung" };
    // Start is called before the first frame update
    private int sceneNum;
    void Start()
    {
        sceneNum = SceneManager.GetActiveScene().buildIndex;
        gameObject.GetComponent<Text>().text = "Level" + sceneNum + ": \n" + StageName[sceneNum - 1];
        
    }

}
