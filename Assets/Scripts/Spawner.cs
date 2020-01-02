using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn; //this is the object that needs to Spawn
    public float adjustmentAngle = 0; //property for the adjustment angle when it is not facing the right way

    public void Spawn()
    {
        Vector3 rotationinDegrees = transform.eulerAngles; //gets the current rotation in degrees 
        rotationinDegrees.z += adjustmentAngle; //adds the adjustment angle to the Z-axis

        Quaternion rotationInRadians = Quaternion.Euler(rotationinDegrees); //converts the rotation into radians

        
        Instantiate(prefabToSpawn, transform.position, rotationInRadians); //spawns the object into the scene 

    }
}
