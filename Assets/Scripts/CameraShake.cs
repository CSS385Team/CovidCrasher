using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float power = 0.7f;
    public float duration = 1.0f;
    public Transform cameraa;
    public float slowDownAmount = 50.0f;
    private bool shouldShake = false;

    Vector3 startPosition;
    float initialDuration;

    private void Start()
    {
        cameraa = Camera.main.transform;
        startPosition = cameraa.localPosition;
    }

    private void Update()
    {
        if(shouldShake)
        {
            if(duration >0)
            {
              
                Vector3 v3 = Random.insideUnitCircle * power;
                cameraa.localPosition = startPosition + v3;


                duration -= Time.deltaTime * slowDownAmount;
            } else
            {
                shouldShake = false;
                duration = initialDuration;
                cameraa.localPosition = startPosition;

            }
        }
        
    }

    public void Shake(float duration, float power)
    {
        this.duration = duration;
        this.power = power;
        shouldShake = true;

    }
}
