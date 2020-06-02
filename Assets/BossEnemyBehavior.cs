using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossEnemyBehavior : MonoBehaviour
{

    void OnDestroy() {
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        Destroy(GameObject.FindGameObjectWithTag("UI"));
        Destroy(GameObject.FindGameObjectWithTag("Music"));
        SceneManager.LoadScene(4);
    }
    
}
