using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleInfo : MonoBehaviour
{
    public GameObject panel;
    bool state = true;

    // Update is called once per frame
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
        }
        panel.gameObject.SetActive(state);
    }
}
