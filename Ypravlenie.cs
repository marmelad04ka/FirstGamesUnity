using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Ypravlenie : MonoBehaviour
{
    public GameObject Level1,GameMenu,Player1,Player11,MainMenu,Setting,Shop,Level2,Player22,Cam22;
    public GameObject tfp1,tfp2,tfp3,BP1,BP2,BP3,tfmc,Pay1,Play1,Pay2,Play2,Cam1,Cam11,fl1,fl2;  
public void PlayLevel1Pressed()
{
    GameMenu.gameObject.SetActive(false);
    coin.coinz = 0;
    Cursor.visible = false;
    Level1.gameObject.SetActive(true);    
     for_player.key = 0;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKey.text = for_player.key.ToString();
    for_player.shtuka = 0;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKolvo.text = for_player.shtuka.ToString();
    for_player.hp = 10;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextHp.text = for_player.hp.ToString();  
}
public void GameMenuPressed()
{
   GameMenu.gameObject.SetActive(true);
   MainMenu.gameObject.SetActive(false); 
}
public void MainMenuPressed()
{
   Setting.gameObject.SetActive(false); 
   MainMenu.gameObject.SetActive(true);  
}
public void SettingPressed()
{
   Setting.gameObject.SetActive(true); 
   MainMenu.gameObject.SetActive(false); 
}
public void ExitPressed()
{
    Application.Quit();
}
public void CloseGameMenuPressed()
{
   GameMenu.gameObject.SetActive(false);
   MainMenu.gameObject.SetActive(true);   
}
public void CloseShopPressed()
{
    GameMenu.gameObject.SetActive(true);
    Shop.gameObject.SetActive(false);
}
public void OpenShopPressed()
{
  GameMenu.gameObject.SetActive(false);
  Shop.gameObject.SetActive(true);  
}
public void Player2Pressed()
{
    tfp1.gameObject.SetActive(false);
    tfp2.gameObject.SetActive(true);
    BP1.gameObject.SetActive(false);
    BP2.gameObject.SetActive(true);
}
public void Player3Pressed()
{
    tfp2.gameObject.SetActive(false);
    tfp3.gameObject.SetActive(true);
    BP2.gameObject.SetActive(false);
    BP3.gameObject.SetActive(true);
}
public void Player1Pressed()
{
    tfp1.gameObject.SetActive(true);
    tfp2.gameObject.SetActive(false);
    BP1.gameObject.SetActive(true);
    BP2.gameObject.SetActive(false);  
}
public void Player32pressed()
{
    tfp2.gameObject.SetActive(true);
    tfp3.gameObject.SetActive(false);
    BP2.gameObject.SetActive(true);
    BP3.gameObject.SetActive(false); 
}
public void OkCenaPressed()
    {
      tfmc.gameObject.SetActive(false);
    }
public void Playlevel2pressed()
{
    GameMenu.gameObject.SetActive(false);
    coin.coinz = 0;
    Cursor.visible = false;
    Level2.gameObject.SetActive(true);    
     for_player.key = 0;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKey2.text = for_player.key.ToString();
    for_player.shtuka = 0;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextKolvo2.text = for_player.shtuka.ToString();
    for_player.hp = 10;
    GameObject.FindGameObjectWithTag ("Player1").GetComponent<for_player> ().TextHp2.text = for_player.hp.ToString();
}
public void nextpressed()
{
    fl1.gameObject.SetActive(false);
    fl2.gameObject.SetActive(true);
}
public void backpressed()
{
  fl1.gameObject.SetActive(true);
    fl2.gameObject.SetActive(false);  
}
}
