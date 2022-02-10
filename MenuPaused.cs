using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPaused : MonoBehaviour
{
    public bool paused = false;
    public GameObject[] allobject;
    public GameObject[] players;
    public GameObject Menu,Level1,Level2,GameMenu,door1,Exit, timelvl2;
    void Strart()
    {
      allobject = GameObject.FindGameObjectsWithTag ("Tryshnie" );
      players = GameObject.FindGameObjectsWithTag ("Player1" );
    }
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Escape)) 
     {
       if(!paused)
       {
           Menu.gameObject.SetActive (true);
           Time.timeScale = 0;
           paused=true;
           Cursor.visible = true;
       }
       else{
             Menu.gameObject.SetActive (false);
             Time.timeScale = 1;
             paused=false;
             Cursor.visible = false;
           }  
    }
    }
    public void RestartPressed()
    {
     Cursor.visible = false;   
    Time.timeScale = 1;
    paused=false;
    Menu.gameObject.SetActive (false);
    Exit.gameObject.SetActive(false);
    door1.gameObject.SetActive(false);
    timelvl2.GetComponent<timelvl>().enabled = false;
    if(Level1){
     coin.coinz = 0;
    for_player.key = 0;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKey.text = for_player.key.ToString();
    for_player.shtuka = 0;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKolvo.text = for_player.shtuka.ToString();
    for_player.hp = 10;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextHp.text = for_player.hp.ToString();
    foreach ( GameObject Tryshnie in allobject )
        {
            Tryshnie.gameObject.SetActive(true);
        }
    foreach ( GameObject Player1 in players )
        {
            Player1.transform.position = new Vector3 (-14,1,40);
        }    
    }
    if(Level2){
    coin.coinz = 0;
    for_player.key = 0;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKey2.text = for_player.key.ToString();
    for_player.shtuka = 0;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKolvo2.text = for_player.shtuka.ToString();
    for_player.hp = 10;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextHp2.text = for_player.hp.ToString();
    foreach ( GameObject Try2 in allobject )
        {
            Try2.gameObject.SetActive(true);
        }
    foreach ( GameObject Player1 in players )
        {
            Player1.transform.position = new Vector3 (-14,1,40);
        }       
    }
    }
    public void ExitPressed()
    {
    GameMenu.gameObject.SetActive(true);
    Time.timeScale = 1;
    paused=false;
    timelvl2.GetComponent<timelvl>().enabled = false;
    coin.coinz = 0;
    Menu.gameObject.SetActive (false);
    Cursor.visible = true;
    foreach ( GameObject Try2 in allobject )
        {
            Try2.gameObject.SetActive(true);
        }
    foreach ( GameObject Player1 in players )
        {
            Player1.transform.position = new Vector3 (-14,1,40);
        } 
    Exit.gameObject.SetActive(false);
    door1.gameObject.SetActive(false);
    if(Level1)
    {
    Level1.gameObject.SetActive(false);    
    }
    if(Level2)
    {
    Level2.gameObject.SetActive(false);    
    }
    }
}



