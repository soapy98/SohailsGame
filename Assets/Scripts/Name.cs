using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public static string nameText;

    public TextMeshProUGUI keyBoardEnter;
   public const float TIME_LIMIT = 30F;
 
    // timer variable
    private float timer = 0F;
   
    

    // Start is called before the first frame update
    void Start()
    {
        nameText = keyBoardEnter.ToString();
    }

   
    
 
    void Update()
    {
       
        this.timer += Time.deltaTime;
 
        // check if it's time to switch scenes
        if (this.timer >= TIME_LIMIT)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

  
}
