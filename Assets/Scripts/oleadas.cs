using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oleadas : MonoBehaviour
{
    [SerializeField] private int waves = 1;
    
    public GameObject[] sp;
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
           
           for(int i = 0; i < waves; i++){
                Debug.Log("prueba " + i);
                sp[i].SetActive(true);

            }
            waves++;
            
        }
        
        //Debug.Log(GameObject.FindGameObjectsWithTag("MeleeEnemy").Length);
        //Debug.Log(noenemies);
        
        
    }

   
}
