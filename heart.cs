using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    public int hill;
    public float b;
    public GameObject[] allobject;
void start()
{
  allobject = GameObject.FindGameObjectsWithTag ("Tryshnie" );
}   
void Update()
{ 
b += 1;
if(b >= 350)
{
  foreach ( GameObject Tryshnie in allobject )
        {
            Tryshnie.gameObject.SetActive(true);
        }
  b = 1;
}
}     
void OnTriggerEnter(Collider col) 
{
    if(col.tag == "Player1")
    {
      /*if(level1){  */
      for_player.hp += hill;
      GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextHp.text = for_player.hp.ToString();
      gameObject.SetActive (false);
      if(for_player.hp >= 10)
      {
          for_player.hp = 10;
          GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextHp.text = for_player.hp.ToString();
      }
    }
}
}
