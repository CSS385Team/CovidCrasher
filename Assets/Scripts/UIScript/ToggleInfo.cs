using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleInfo : MonoBehaviour
{
    public GameObject panel;
    bool state = true;
    public static bool gameIsPaused = true;
    public Weapon waterBlaster;
    // Update is called once per frame

    private void Awake()
    {
        waterBlaster = GameObject.Find("Projectile").GetComponent<Weapon>();
        Pause();

    }
    void Update()
    {
        SwitchShowHide();
    }

    public void SwitchShowHide()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("Toggle info!");
            state = !state;

            if (gameIsPaused == true)
                {
                   Resume();
               }
                else
                {
                    Pause();
            }
        }
        panel.gameObject.SetActive(state);
    }
    void Resume()
    {
        //pauseScreen.SetActive(false);
        //waterBlaster.allowShoot();
        //Time.timeScale = 1f;
        //gameIsPaused = false;
        waterBlaster.allowShoot();
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause()
    {
        //pauseScreen.SetActive(true);
        //waterBlaster.blockShoot();
        //Time.timeScale = 0f;
        //gameIsPaused = true;
        waterBlaster.blockShoot();
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

}

