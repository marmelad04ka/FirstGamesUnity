using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExitLevel : MonoBehaviour
{
    public static int summa; 
    public Text TextSumma;
    public GameObject[] allobject;
    public GameObject[] players;
    public GameObject Level1,level2,GameMenu,door1,Exit;
   void start()
   {
     allobject = GameObject.FindGameObjectsWithTag ("Tryshnie" );
      players = GameObject.FindGameObjectsWithTag ("Player1" );
   }
   void OnTriggerEnter(Collider col)
   {
       if(col.tag == "Player1")
       {
         summa += coin.coinz;
         TextSumma.text = summa.ToString();
         GameMenu.gameObject.SetActive(true);
         Cursor.visible = true;
         Exit.gameObject.SetActive(false);
         door1.gameObject.SetActive(false);
         foreach ( GameObject Tryshnie in allobject )
        {
            Tryshnie.gameObject.SetActive(true);
        }
         foreach ( GameObject Player1 in players )
        {
            Player1.transform.position = new Vector3 (-14,1,40);
        }
        Level1.gameObject.SetActive(false);  
        level2.gameObject.SetActive(false); 
        
       }
}
}

