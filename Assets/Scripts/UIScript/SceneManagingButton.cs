using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagingButton : MonoBehaviour
{
    public void reloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Destroy(GameObject.Find("DoctorPlayer"));
        Destroy(GameObject.Find("UI"));

    }

    public void goBackToMenu()
    {
        SceneManager.LoadScene(0);
        Destroy(GameObject.Find("DoctorPlayer"));
        Destroy(GameObject.Find("UI"));
    }
}
