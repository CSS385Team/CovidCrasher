using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// Gabe: Code inspired by this YouTube Video:
// https://www.youtube.com/watch?v=9lPCv9kkbSI

public class EndGoalBehavior : MonoBehaviour
{
    void OnTriggerEnter2D() {
        Debug.Log("Collided!");
        SceneManager.LoadScene("Level2Esophagus");
    }
}
