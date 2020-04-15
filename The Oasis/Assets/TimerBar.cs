using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class TimerBar : MonoBehaviour
{
    public float maximum;
    public float current;
    public float timerModifier;
    public Image mask; 
    void Start()
    {

    }
    void GetCurrentFill()
    {
        float fillamount = (float)current / (float)maximum;
        mask.fillAmount = fillamount;
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }
}
