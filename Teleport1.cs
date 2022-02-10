using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Работа с интерфейсами
using UnityEngine.SceneManagement; //Работа со сценами
public class Teleport1 : MonoBehaviour
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
            Player1.transform.position = new Vector3 (-17,7,21);
            Player1.transform.Rotate(0, 180, 0);
        }
    }                           
}
}
