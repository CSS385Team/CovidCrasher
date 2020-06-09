using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderScript : MonoBehaviour
{
    // Level loading help from this Youtube video:
    // https://www.youtube.com/watch?v=CE9VOZivb3I
    // and
    // https://answers.unity.com/questions/42843/referencing-non-static-variables-from-another-scri.html

    public Animator transition;

    public GameObject goal;
    private EndGoalBehavior GoalScript;

    public float transitionTime = 1f;
    
    void start() {
        goal = GameObject.Find("End_Goal");
        /*EndGoalBehavior */GoalScript = goal.GetComponent<EndGoalBehavior>();
    }
    void Update()
    {
        if (goal.GetComponent<EndGoalBehavior>().goalReached == true) {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel() {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex) {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
