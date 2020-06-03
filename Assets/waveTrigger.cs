using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveTrigger : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject waveSpawner1;
    public GameObject waveSpawner2;
    public CameraShake cameraShake;
    public AudioClip earthQuakeSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            transform.parent.gameObject.transform.parent.gameObject.GetComponent<AudioSource>().PlayOneShot(earthQuakeSound, 0.3f);
            cameraShake.Shake(1.5f, 0.25f, 0.05f);
            waveSpawnEnemies();
            
        }
    }

    public void waveSpawnEnemies()
    {
        foreach (Transform child in waveSpawner1.transform)
        {
            Vector3 spawnPos = child.position;
            spawnPos.z = 0;
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }
        foreach (Transform child in waveSpawner2.transform)
        {
            Vector3 spawnPos = child.position;
            spawnPos.z = 0;
            Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
        }
        gameObject.transform.parent.gameObject.SetActive(false);
    }
    


}
