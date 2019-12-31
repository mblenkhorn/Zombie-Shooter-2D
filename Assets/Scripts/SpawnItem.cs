using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{

    public GameObject Item; //this is the object that will spawn


    public void GenerateItem()
    {
        Instantiate(Item, transform.position, Quaternion.identity); //Spawns an Object with no rotations 
    }
}
