using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHealth : MonoBehaviour
{
    public GameObject healthRestore; //health object 

    public void Spawn()
    {
        Instantiate(healthRestore, transform.position, Quaternion.identity); //spawns health object without rotation
    }

}
