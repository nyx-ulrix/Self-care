using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fatigue : MonoBehaviour
{
    public Slider fatigue;

    public void Start()
    {
        PlayerPrefs.GetFloat("Fatigue");
        SetFatigue(PlayerPrefs.GetFloat("Fatigue"));
    }
    //code used to set the value of the slider
    public void SetFatigue(float fatigueValue)
    {
        fatigue.value = fatigueValue;
    }
}