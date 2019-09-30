using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerDestroy : MonoBehaviour
{
    private int enemyCount = 0;
    public int maxEnemyCount = 12;
    public float timeBetweenSpawns = 2.0f;
 
    void Start(){
        InvokeRepeating("Spawn", 0, timeBetweenSpawns);
    }
 
    void Spawn(){
   
        //Your instantiate stuff here
 
        enemyCount++;
        if(enemyCount>=maxEnemyCount){
            
        }
    }
}
