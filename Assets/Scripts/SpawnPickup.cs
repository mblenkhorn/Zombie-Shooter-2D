﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickup : MonoBehaviour
{
    public GameObject coinSpawn;


    private void Start()
    {
        Invoke("CoinSpawn", 2f);
    }

    public void CoinSpawn()
    {
        
        Instantiate(coinSpawn, transform.position, transform.rotation);
        
    }

   
    
}
