using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oleadas : MonoBehaviour
{
    public bool noenemies = false;
    public int waves = 1;
    public GameObject enemytype;
    private GameObject[] sp;
    void Start()
    {
        sp = GameObject.FindGameObjectsWithTag("Spawners");
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("MeleeEnemy").Length <= 0){
            noenemies = true;
        }
        spawn();
        //Debug.Log(GameObject.FindGameObjectsWithTag("MeleeEnemy").Length);
        //Debug.Log(noenemies);
        
        
    }

    void spawn(){
        if(noenemies){
            noenemies = false;
            
            GameObject enemyClone = Instantiate(enemytype);
        }

    }
}
