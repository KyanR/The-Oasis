using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameObject Player;
    public EvidenceCollectable Evidence;

    public static int supCount;
    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player)
        {
            Destroy(this.gameObject);
            supCount++;

        }
          
            
    }

}
