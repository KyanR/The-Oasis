using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5f; 

    public Rigidbody2D rb;

    Vector2 movement;
    public Animator animator;

    public static bool elderHQDoor = false;
    public static bool homeDoor = false;


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

    private void OnTriggerEnter2D(Collider2D door)
    {
        if (door.gameObject.tag == "ElderHQTrigger")
        {
            elderHQDoor = true;
            Debug.Log(elderHQDoor);
        }

        if (door.gameObject.tag == "HomeTrigger")
        {
            homeDoor = true;
        }
    }
}
