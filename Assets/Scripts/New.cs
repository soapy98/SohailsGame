using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class New : MonoBehaviour
{
    public Text path;
    // Start is called before the first frame update
    private new string app;
    void Start()
    {

        app = Application.persistentDataPath;
        path.text = app;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
