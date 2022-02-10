using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
using UnityEngine.UI;
public class SaveSerial : MonoBehaviour
{

public int money;
public float time1,time2;
public Text TextTime1,TextTime2, TextMoney;

[Serializable]
class SaveData
{
  public int savedInt;
  public float savedFloat1,savedFloat2;
}
public void SaveGame()
{
  BinaryFormatter bf = new BinaryFormatter(); 
  FileStream file = File.Create(Application.persistentDataPath 
    + "/MySaveData.dat"); 
  SaveData data = new SaveData();
  data.savedFloat1 = time1;
  data.savedFloat2 = time2;
  time1 = besttime.best2;
  time2 = besttime.best33;
  data.savedInt = money;
  money = ExitLevel.summa;
  bf.Serialize(file, data);
  file.Close();
  Debug.Log("Game data saved!");
}
public void LoadGame()
{
  if (File.Exists(Application.persistentDataPath 
    + "/MySaveData.dat"))
  {
    BinaryFormatter bf = new BinaryFormatter();
    FileStream file = 
      File.Open(Application.persistentDataPath 
      + "/MySaveData.dat", FileMode.Open);
    SaveData data = (SaveData)bf.Deserialize(file);
    file.Close();
    time1 = data.savedFloat1;
    time2 = data.savedFloat2;
    besttime.best2 = time1;
    besttime.best33 = time2;
    TextTime1.text = besttime.best2.ToString();
    TextTime2.text = besttime.best33.ToString();
    money = data.savedInt;
    ExitLevel.summa = money;
    TextMoney.text = ExitLevel.summa.ToString();
    Debug.Log("Game data loaded!");
  }
  else
    Debug.LogError("There is no save data!");
}
public void ResetData()
{
  if (File.Exists(Application.persistentDataPath 
    + "/MySaveData.dat"))
  {
    File.Delete(Application.persistentDataPath 
      + "/MySaveData.dat");
    time1 = 999;
    time2 = 999;
    money = 0;
    Debug.Log("Data reset complete!");
  }
  else
    Debug.LogError("No save data to delete.");
}
}
