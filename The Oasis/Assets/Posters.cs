using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posters : MonoBehaviour
{
    public GameObject poster;
    private bool triggerActive = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        triggerActive = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        triggerActive = false;
    }

    void Update()
    {
        if (triggerActive == true && Input.GetKeyDown(KeyCode.Space))
        {
            poster.SetActive(true);
            Debug.Log("Post Placed");
        }
    }
}
