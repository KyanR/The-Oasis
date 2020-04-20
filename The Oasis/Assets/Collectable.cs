using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public GameObject Player;
    //public EvidenceCollectable Evidence;
    public GameObject chestOpen;
    public GameObject book;

    public static int supCount;
    public static float inf;
    bool opened;

    //public Image influenceCount;

    private void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player && opened == false)
        {
            Instantiate(book, transform.position, Quaternion.identity);
            chestOpen.gameObject.SetActive(true);
            opened = true;
            
        }
    }

    private void Update()
    {
        
    }

}
