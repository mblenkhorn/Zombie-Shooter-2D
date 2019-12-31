using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPickup : MonoBehaviour
{
    public GameObject coinSpawn; //this is the coin object 


    private void Start()
    {
        //Invoke("CoinSpawnDelay", 2f);
    }

    public void CoinSpawnDelay()
    {
        
        //Instantiate(coinSpawn, transform.position, Quaternion.identity); //spawns a coin without rotation
        
    }

    public void RockSpawnCoins()
    {
        Instantiate(coinSpawn, transform.position, Quaternion.identity); //spawns a coin without rotation

    }

   
    
}
