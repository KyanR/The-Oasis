using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Image timerBar;
    public Image influenceBar;

    private void Start()
    {
        influenceBar.fillAmount += Collectable.inf;
    }
    void Update()
    {
        timerBar.fillAmount = LinearTimer.timeLeft / LinearTimer.maxTime;
        LinearTimer.timeLeft -= Time.deltaTime;

      

        if (timerBar.fillAmount == 0f)
        {
            Debug.Log("Times Up");
        }
    }
}
