using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource[] AudioSource;
    void Start()
    {
        
    }
    void footsteps()
    {
        foreach(var audiosource in AudioSource)
        {
            audiosource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
