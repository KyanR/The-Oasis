using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Elder_AI : MonoBehaviour
{
    Animator animation;
    NavMeshAgent agent; 
    void Start()
    {
        animation = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {

        animation.SetFloat("Speed", agent.velocity.magnitude);
    }
}
