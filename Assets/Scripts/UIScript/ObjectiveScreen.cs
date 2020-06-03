using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectiveScreen : MonoBehaviour
{
    public float time = 4f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Destroy(gameObject, time);
    }
}
