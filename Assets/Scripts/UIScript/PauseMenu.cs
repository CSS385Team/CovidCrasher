﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = true;

    public GameObject pauseScreen;
    public Weapon waterBlaster;

    private void Start()
    {
        Pause();
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            if(gameIsPaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    void Resume()
    {
        pauseScreen.SetActive(false);
        waterBlaster.allowShoot();
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    void Pause()
    {
        pauseScreen.SetActive(true);
        waterBlaster.blockShoot();
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}