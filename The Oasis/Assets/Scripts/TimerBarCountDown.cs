using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "TimerBar", menuName = "new TimberBar")]
public class TimerBarCountDown : ScriptableObject
{

    public  float maxTime = 100f;
    public float timeLeft;

    private void OnEnable()
    {
        timeLeft = 0;
        timeLeft = maxTime;

    }
}
