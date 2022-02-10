using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class timelvl : MonoBehaviour
{
bool indicator;
public GameObject timelvl2,timevr; 
public Text time1;
public static float b;
public static float time3, time4;
void Update()
{
    if(indicator)
    {
     b -= Time.deltaTime;
     b = 1;   
     time3 += b;
     if(time3 >= 30){
     time3 = 0;
     time4 += 1;
     time1.text =""+ time4;
     }
    }
}    
void OnTriggerEnter(Collider col)
{
    indicator = true;
    timevr.gameObject.SetActive (true);
    timelvl2.GetComponent<timelvl>().enabled = true;
    time4 = 0;
    
}
}
