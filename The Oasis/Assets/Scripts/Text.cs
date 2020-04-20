using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text : MonoBehaviour
{
    public TextMeshProUGUI supCount;
    void Update()
    {
        supCount.SetText("Influence: " + Collectable.supCount.ToString());

    }
}
