using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagingButton : MonoBehaviour
{
    public void reloadCurrentScene()
    {
        
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        Destroy(GameObject.FindGameObjectWithTag("UI"));
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void goBackToMenu()
    {
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        Destroy(GameObject.FindGameObjectWithTag("UI"));
        SceneManager.LoadScene(0);
    }
}
