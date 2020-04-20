using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TimerManager : MonoBehaviour
{
    public Image timerBar;
    public TimerBarCountDown BarTimer;

    void Update()
    {

            if (BarTimer.timeLeft > 0)
            {
                BarTimer.timeLeft -= Time.deltaTime;
                timerBar.fillAmount = BarTimer.timeLeft / BarTimer.maxTime;
               
            }


    }
}
