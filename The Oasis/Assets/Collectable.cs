using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public GameObject Player;
    public EvidenceCollectable Evidence;

    public static int supCount;
    public static float inf;

    public Image influenceCount;

    private void Start()
    {
        inf = influenceCount.fillAmount;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == Player)
        {
            Destroy(this.gameObject);
            supCount++;
            influenceCount.fillAmount -= 0.1f;
        }
          
            
    }

}
