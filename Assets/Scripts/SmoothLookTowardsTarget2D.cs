using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothLookTowardsTarget2D : MonoBehaviour
{

    public Transform target; //gets transform component of the object the that Zombie will rotate towards 
    public float smoothing = 5.0f; //controls the smoothness of the rotation 
    public float adjustmentAngle = 0.0f; //compensates the artwork when it is not facing the right way 

    private void Update()
    {
        if(target != null) //checks to see if the target has been set 
        {
            Vector3 difference = target.position - transform.position; //gets the difference between target position and our current position

            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg; //gets our Z-axis using Atan2 method

            Quaternion newRot = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotZ + adjustmentAngle)); //creates a new rotation adding our new Z-axis and the adjustment angle 

            transform.rotation = Quaternion.Lerp(transform.rotation, newRot, Time.deltaTime * smoothing); //sets the rotation from animating the transform.rotation to newRot, over the time multipled by the smoothing 


        }

    }


    public void SetTarget(Transform newTarget) //a method to set the Target with a transform parameter 
    {
        target = newTarget; //sets the public variable target to the value of the parameter newTarget
    }





}
