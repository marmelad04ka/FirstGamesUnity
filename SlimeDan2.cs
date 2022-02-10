using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeDan2 : MonoBehaviour
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
            Player1.transform.position = new Vector3 (35,-1,-40);
            Debug.Log(22);
        }
        
    }
}
}


