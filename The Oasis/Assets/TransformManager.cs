using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformManager : MonoBehaviour
{
    public Transform player;
    public Transform elderExitPoint;
    public Transform homeExitPoint;



    void Start()
    {
        Debug.Log(Player.elderHQDoor);
        if(Player.elderHQDoor == true)
        {
            player.transform.position = elderExitPoint.transform.position;
            Player.elderHQDoor = false;
        }
        if (Player.homeDoor == true)
        {
            player.transform.position = homeExitPoint.transform.position;
            Player.homeDoor = false;
        }
        
    }
    
}
