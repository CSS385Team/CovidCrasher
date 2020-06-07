using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Queue<string> sentences;
    public Text dialogue;

    //void Start()
    //{
    //    sentences = new Queue<string>();
    //}

    private void OnEnable()
    {
        sentences = new Queue<string>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            loadNextScene();
        }
    }

    //call when play is clicked
    public void StartDialogue (Dialogue dialogue)
    {
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentences();
    }
    public void DisplayNextSentences()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogue.text = sentence;
    }

    public void EndDialogue()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
        {
            loadNextScene();
        }
    }

    public void loadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
