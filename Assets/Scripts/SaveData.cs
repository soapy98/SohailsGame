using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class SaveData : MonoBehaviour
{
    
    private static int score;
    private static float tim; 
    public static string nam;
    public static TextMeshProUGUI Name;
   
    public Text ScoreText;
   
    public Text TimeTaken;
    // Start is called before the first frame update
    void Start()
    { 
        
        score = Collecting._collected;
       tim = Collecting.tim;
       ScoreText.text = score.ToString();
       TimeTaken.text = tim.ToString();
       Name.text = nam;
     
      

    }

    private Saving saveGameData()
    {
        
        Saving save = new Saving();
        Saving.names = nam;
        Saving.scores = score;
        Saving.times = tim;
        return save;
    }

  

    public void SaveGame()
    {
        Saving save = saveGameData();
        
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath +"file.txt");
        bf.Serialize(file, save);
        file.Close();

        Name.text = nam;
        ScoreText.text = score.ToString();
        TimeTaken.text = tim.ToString();
       
        

    }

}
