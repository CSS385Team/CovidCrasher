﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Dialogue IntroDialogue;
    public GameObject DialogueBox;
    public Image img;


    public void PlayGame()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        gameObject.transform.GetChild(1).gameObject.SetActive(false);
        DialogueBox.SetActive(true);
        gameObject.transform.GetChild(2).gameObject.SetActive(false);

        DialogueBox.GetComponent<DialogueManager>().StartDialogue(IntroDialogue);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }

    void Start()
    {
        img.enabled = true;
    }

    public void Hide()
    {
        img.enabled = false;
    }

}