using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Collecting : MonoBehaviour
{
    public AudioSource tickSource;
   
    public static int _collected;
    public static float tim;
   
   
    public Text scoreText;
    public Text winText;
    
    private void Start()
    {
        _collected = 0;
        winText.text = "";
        tim = Time.realtimeSinceStartup;
        
        tickSource = GetComponent<AudioSource>();
    }




    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("collectable"))
        {
            other.gameObject.SetActive(false);
            _collected++; // count = count + 1 != ++count
            setCountText();
            tickSource.Play();
            Destroy(other.gameObject);
        }

        
    }

    void setCountText()
    {
        
        winText.gameObject.SetActive((false));
        scoreText.text = "Score: " + _collected.ToString();
        if (_collected >= 6 )
        {
            winText.gameObject.SetActive((true));
            scoreText.gameObject.SetActive((false));
            winText.text = "You win in:" + tim;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
        }
    }
    
}
