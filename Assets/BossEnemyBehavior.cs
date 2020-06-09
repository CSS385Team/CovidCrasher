using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossEnemyBehavior : MonoBehaviour
{
    public HealthSystem enemyHealth;
    bool enemyDied = false;

    public void died()
    {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            Destroy(GameObject.FindGameObjectWithTag("UI"));
            Destroy(GameObject.FindGameObjectWithTag("Music"));
            SceneManager.LoadScene(4);
       
    }
    
}
