using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public GameObject line,line3,line4;
    public bool oto = false;
    public bool boto = false;
    public bool doto = false;
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Q)) 
       {
           if(!oto)
           {
           line.gameObject.SetActive(true); 
           oto = true;
           }
           else
           {
             oto =false;
             line.gameObject.SetActive(false); 
           }
       }
      if(Input.GetKeyDown(KeyCode.E)) 
       {
           if(!boto)
           {
           line3.gameObject.SetActive(true); 
           boto = true;
           }
           else
           {
             boto =false;
             line3.gameObject.SetActive(false); 
           }
       }
       if(Input.GetKeyDown(KeyCode.F)) 
       {
           if(!doto)
           {
           line4.gameObject.SetActive(true); 
           doto = true;
           }
           else
           {
             doto =false;
             line4.gameObject.SetActive(false); 
           }
       }
    }
}


