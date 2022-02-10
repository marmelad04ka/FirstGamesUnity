using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDeath : MonoBehaviour
{
 public GameObject[] players; 
 public GameObject[] allobject;  
public GameObject door1,Exit,level1,level2;
 void start()
 {
     players = GameObject.FindGameObjectsWithTag ("Player1" );
     allobject = GameObject.FindGameObjectsWithTag ("Tryshnie" );
 }
 void OnTriggerEnter(Collider col) 
{
    if(col.tag == "Player1")
    {
    if(level1){    
    Cursor.visible = false; 
    door1.gameObject.SetActive(false);
    Exit.gameObject.SetActive(false);
    for_player.key = 0;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKey.text = for_player.key.ToString();
    for_player.shtuka = 0;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKolvo.text = for_player.shtuka.ToString();    
    for_player.hp = 10;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextHp.text = for_player.hp.ToString();
    foreach ( GameObject Player1 in players )
        {
            Player1.transform.position = new Vector3 (-14,1,40);
        }
    foreach ( GameObject Tryshnie in allobject )
        {
            Tryshnie.gameObject.SetActive(true);
        }    
     }
    
    if(level2){
     Cursor.visible = false; 
    door1.gameObject.SetActive(false);
    Exit.gameObject.SetActive(false);
    for_player.key = 0;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKey2.text = for_player.key.ToString();
    for_player.shtuka = 0;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKolvo2.text = for_player.shtuka.ToString();    
    for_player.hp = 10;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextHp2.text = for_player.hp.ToString();
    foreach ( GameObject Player1 in players )
        {
            Player1.transform.position = new Vector3 (-14,1,40);
        }
    foreach ( GameObject Tryshnie in allobject )
        {
            Tryshnie.gameObject.SetActive(true);
        }     
    } 
}
}
}
