using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Just TEST SCRIPT! 
*/
public class CameraShakeTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public CameraShake cameraShake;
    public float duration = 1f;
    public float magnitude = .4f;
    public float rate = .05f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("camera shake!");
            cameraShake.Shake(duration, magnitude, rate);
           
        }
    }
}
