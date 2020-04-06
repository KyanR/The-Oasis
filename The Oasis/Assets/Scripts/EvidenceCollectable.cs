using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new Evidence", menuName = "Evidence")]
public class EvidenceCollectable : ScriptableObject
{
    public new string name;
    public Sprite image;
    public int supportersGained;

}
