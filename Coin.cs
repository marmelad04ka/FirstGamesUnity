using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coin : MonoBehaviour
{
    public GameObject[] players;
    public GameObject[] cam;
	public int Cena,kolvo;
    static public int Cena1 = 10000, Cena2 = 20000, Cena0 = 0, coinz;
    public GameObject Player2, Cam2,tfmc,level1,level2,Player1,Cam1,Player3,Cam3,Player11,Cam11,Player22,Cam22,Player33,Cam33;
    void start()
    {
      players = GameObject.FindGameObjectsWithTag ("Player1" );
      cam = GameObject.FindGameObjectsWithTag ("Cam" );
    }
	void OnTriggerEnter(Collider col) { 
		coinz += Cena;
		gameObject.SetActive (false);
        for_player.shtuka += kolvo;
        if(level1){
        GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKolvo.text = for_player.shtuka.ToString();}
        if(level2){
         GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKolvo2.text = for_player.shtuka.ToString();   
        }
		}
    public void PayPlayer1Pressed()
{
    if (Cena1 <= ExitLevel.summa)
    {   
        foreach (GameObject Player1 in players)
        {
             Player1.gameObject.SetActive(false);
        }
        foreach (GameObject Cam in cam)
        {
            Cam.gameObject.SetActive(false);
        }
    Player2.gameObject.SetActive(true);
    Cam2.gameObject.SetActive(true); 
    Player22.gameObject.SetActive(true);
    Cam22.gameObject.SetActive(true);  
    }
    else
    {
       tfmc.gameObject.SetActive(true); 
    }
}
public void PayPlayer2Pressed()
{
    if (Cena2 <= ExitLevel.summa)
    {
        foreach (GameObject Player1 in players)
        {
             Player1.gameObject.SetActive(false);
        }
        foreach (GameObject Cam in cam)
        {
            Cam.gameObject.SetActive(false);
        }
    Player3.gameObject.SetActive(true);
    Cam3.gameObject.SetActive(true); 
    Player33.gameObject.SetActive(true);
    Cam33.gameObject.SetActive(true);
    }
    else
    {
       tfmc.gameObject.SetActive(true); 
    }
}
public void PayPlayer0Pressed()
{
    if (Cena0 <= ExitLevel.summa)
    {
        foreach (GameObject Player1 in players)
        {
             Player1.gameObject.SetActive(false);
        }
        foreach (GameObject Cam in cam)
        {
            Cam.gameObject.SetActive(false);
        }
    Player1.gameObject.SetActive(true);
    Cam1.gameObject.SetActive(true); 
    Player11.gameObject.SetActive(true);
    Cam11.gameObject.SetActive(true); 
    }
}   
}

