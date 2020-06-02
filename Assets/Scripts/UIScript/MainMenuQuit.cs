using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuQuit : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
        Destroy(GameObject.Find("DoctorPlayer"));
        Destroy(GameObject.Find("UI"));
        Destroy(GameObject.Find("LevelMusic"));
    }
}
