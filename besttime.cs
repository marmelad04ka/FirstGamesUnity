using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class besttime : MonoBehaviour
{
public GameObject timelvl2, timevr,level1,level2;    
public static float best1,best2,best3,best33;
public  float best,best11;
public Text best4,best5;    
void OnTriggerEnter(Collider col)
{
    if(level1){
    timelvl2.GetComponent<timelvl>().enabled = false;
    best1 = timelvl.time4; 
    if(best > best1)
    {
        best = timelvl.time4;
        best2 = best;
        best4.text = ""+ best2;
    }
    }
    if(level2){
    timelvl2.GetComponent<timelvl>().enabled = false;
    best3 = timelvl.time4; 
    if(best11 > best33)
    {
        best11 = timelvl.time4;
        best33 = best11;
        best5.text = ""+ best33;
    }    
    }
}
}
