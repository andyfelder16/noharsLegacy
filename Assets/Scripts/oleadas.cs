using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oleadas : MonoBehaviour
{
    public bool noenemies = false;
    public int waves = 1;
    
    private GameObject[] sp;
    void Start()
    {
        sp = GameObject.FindGameObjectsWithTag("Spawners");
        for(int i = 0; i < sp.Length; i++){
            sp[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("MeleeEnemy").Length <= 0){
            noenemies = true;
            for(int i = 0; i < sp.Length; i++){
            sp[i].SetActive(true);
        }
        };
        //Debug.Log(GameObject.FindGameObjectsWithTag("MeleeEnemy").Length);
        //Debug.Log(noenemies);
        
        
    }

    
}
