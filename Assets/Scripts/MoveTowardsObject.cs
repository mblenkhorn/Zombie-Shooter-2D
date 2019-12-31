using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardsObject : MonoBehaviour
{

    public Transform target; //target for the Zombie to move to 
    public float speed = 5.0f; //speed of the Zombie 


    private void Update()
    {
        if(target != null) //checks to see if the property has a value 
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * 0.01f); //moves the Zombie by the set speed from its current position to the target position 
        }
    }


    public void SetTarget(Transform newTarget) //a method to set the Target with a transform parameter 
    {
        target = newTarget; //sets the public variable target to the value of the parameter newTarget 
    }





}
