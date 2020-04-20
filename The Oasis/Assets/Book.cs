using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    float timeleft = 2f;

    void Update()
    {
        timeleft -= Time.deltaTime;

        if (timeleft <= 0)
        {
            Destruction();
        }
    }

    void Destruction()
    {
        Destroy(this.gameObject);
        Collectable.supCount++;
    }
}
