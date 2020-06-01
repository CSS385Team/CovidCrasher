using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    
    private float power = 0.7f; //the range of shaking
    private float duration = 1.0f; //duration of shaking
    private float slowDownAmount = 1.0f;  
    private float rate = 0.05f;  //how fast it shakes 

    private bool shouldShake = false; //shake when true

    Vector3 startPosition;
    float initialDuration;

    public Transform cameraa;

    private void Start()
    {
        cameraa = Camera.main.transform;
        startPosition = cameraa.localPosition;
        
    }



    public void Shake(float duration, float power, float rate)
    {
        this.duration = duration;
        this.power = power;
        this.rate = rate;
        shouldShake = true;
        InvokeRepeating("SlowUpdate", 0.0f, rate);
    }



    private void SlowUpdate()
    {
            if (duration > 0)
            {

                Vector3 v3 = Random.insideUnitCircle * power;
                cameraa.localPosition = startPosition + v3;            
            }
            else
            {
                shouldShake = false;
                duration = initialDuration;
                cameraa.localPosition = startPosition;
                CancelInvoke();
        }
        
    }

    private void Update()
    {
        if(shouldShake)
        {
            if(duration >0)
            {
                duration -= Time.deltaTime * slowDownAmount;
            }

        }
        
    }

}
