using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    [SerializeField] 
    int cantidadE;
    public GameObject enemytype;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cantidadE > 0){
        spawnE();
        cantidadE--;
        }
    }

    void spawnE(){
       
            
            GameObject enemyClone = Instantiate(enemytype);
        
    }
}
