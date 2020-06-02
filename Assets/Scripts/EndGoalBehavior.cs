using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// Gabe: Code inspired by this YouTube Video:
// https://www.youtube.com/watch?v=9lPCv9kkbSI

public class EndGoalBehavior : MonoBehaviour
{
    private string sceneName;

    void Start() {
        sceneName = SceneManager.GetActiveScene().name;
    }

    void OnTriggerEnter2D() {
        Debug.Log("Collided!");
        if (sceneName == "UISampleScene") {
            SceneManager.LoadScene("Level2Esophagus");
        } else {
            SceneManager.LoadScene("Level3Lungs");
        }
    }
}
