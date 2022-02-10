using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport2 : MonoBehaviour
{
public GameObject[] players;
void start()
{
    players = GameObject.FindGameObjectsWithTag ("Player1" );
}
void OnTriggerEnter(Collider col) 
{
    if(col.tag == "Player1")
    {
        foreach ( GameObject Player1 in players )
        {
            Player1.transform.position = new Vector3 (20,-1,-17);
            Player1.transform.Rotate(0, 180, 0);
        }
        
    }
}
}
