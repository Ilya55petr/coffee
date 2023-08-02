using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawn : MonoBehaviour
{
    public List<GameObject> ingridients = new List<GameObject>();

    public void Start()
    {
       Spawner();
    }


    public void Spawner()
    {
        ingridients [Random.Range(0, ingridients.Count)].SetActive(true);
        
       
    }
    
    


  
}
