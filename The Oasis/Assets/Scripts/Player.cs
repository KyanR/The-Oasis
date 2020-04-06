using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5f; 

    public Rigidbody2D rb;

    Vector2 movement;
    public Animator animator;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       movement.x = Input.GetAxis("Horizontal");
       movement.y = Input.GetAxis("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        rb.velocity = new Vector2(movement.x, movement.y);
    }
}
