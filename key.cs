using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class key : MonoBehaviour
{
	public int Cena;
	public GameObject door,door1,Exit,level1,level2; 
	void OnTriggerEnter(Collider col) { 
		if (level1){
		for_player.key += Cena;
		if(for_player.key >=3)
		{
			door.gameObject.SetActive(false);
			door1.gameObject.SetActive(true);
			Exit.gameObject.SetActive(true);
			Debug.Log ("yes");
		}
		GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKey.text = for_player.key.ToString(); 
		gameObject.SetActive (false);
		}
		if (level2){
		for_player.key += Cena;
		if(for_player.key >=6)
		{
			door.gameObject.SetActive(false);
			door1.gameObject.SetActive(true);
			Exit.gameObject.SetActive(true);
			Debug.Log ("yes");
		} 
		GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKey2.text = for_player.key.ToString(); 
		gameObject.SetActive (false);
		}
	}
}

