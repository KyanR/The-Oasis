using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LinearTimer : MonoBehaviour
{
    Image timerBar;
    public static float maxTime = 100f;
    public static float timeLeft;
    public static bool gameover;




    void Start()
    {
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }


    void Update()
    {
       
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            Time.timeScale = 0;
            gameover = true;
            Debug.Log("game over");
        }

    }
}
