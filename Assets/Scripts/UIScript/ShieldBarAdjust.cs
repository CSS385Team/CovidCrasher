using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ShieldBarAdjust : MonoBehaviour
{
    public Slider slider;

    public void setShield(int shield)
    {
        slider.value = shield;
    }

    public void buyShield(int shield)
    {
        slider.maxValue = 5;
        slider.value = shield;
    }
}
