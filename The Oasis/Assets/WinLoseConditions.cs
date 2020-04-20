using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseConditions : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject loseScreen;
    public TimerBarCountDown timerEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Collectable.supCount == 3)
        {
            winScreen.gameObject.SetActive(true);
        }
        if (timerEnd.timeLeft <= 0)
        {
            loseScreen.gameObject.SetActive(true);
        }
       
    }
}
