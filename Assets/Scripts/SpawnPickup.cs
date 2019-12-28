using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickup : MonoBehaviour
{
    public GameObject coinSpawn; //this is the coin object 


    private void Start()
    {
        Invoke("CoinSpawn", 2f);
    }

    public void CoinSpawn()
    {
        
        Instantiate(coinSpawn, transform.position, Quaternion.identity); //spawns a coin without rotation
        
    }

   
    
}
