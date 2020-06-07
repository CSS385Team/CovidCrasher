using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickIndicator : MonoBehaviour {

    private void Start()
    {
        BlinkOff();
    }
    

    private void BlinkOff()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
        //   renderer.enabled = false;
        Invoke("BlinkOn", 0.2f);
    }

    private void BlinkOn()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(true);
        Invoke("BlinkOff", 0.5f);
    }

    public void destory()
    {
        Destroy(gameObject);
    }



}