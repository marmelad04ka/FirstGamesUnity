using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shipi : MonoBehaviour
{
public GameObject[] players;
public GameObject level1,level2;
void start()
{
    players = GameObject.FindGameObjectsWithTag ("Player1" );
}
void OnTriggerEnter(Collider col) 
{
    if(col.tag == "Player1")
    { if(level1){
        foreach ( GameObject Player1 in players )
        {
            Player1.transform.position = new Vector3 (16,7,25);
        }
    }
    if (level2){
     foreach ( GameObject Player1 in players )
        {
            Player1.transform.position = new Vector3 (30,0,-40);
        }   
    }
    }
}
}
