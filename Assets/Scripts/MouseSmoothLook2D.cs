using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSmoothLook2D : MonoBehaviour
{

    public Camera theCamera; //camera position so that mouse position can be offset while running 
    public float smoothing = 5.0f; //controls the smoothness of rotation the player uses when rotating towards the mouse pointer 
    public float adjustmentAngle = 0.0f; //compensates for the artwork not facing the right way: turned three quarters if facing north (90 degrees)


    // Update is called once per frame
    void Update()
    {
        Vector3 target = theCamera.ScreenToWorldPoint(Input.mousePosition); //gets the screen position of the mouse pointer and converts to a point in the game world 
        Vector3 difference = target - transform.position; //gets the difference between player position and the mouse point in the game world

        difference.Normalize(); //keeps the direction the difference variable is pointing in, but reduces the size of the values 

        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg; //calculates the angle of the difference between the mouse pointer and the player in the game world 
        Quaternion newRotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, rotZ + adjustmentAngle)); //creates a new rotation that includes our new calcuated angle and the adjustment angle 
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, Time.deltaTime * smoothing); //sets our new rotation by animating it with a linear interpolation 



        
    }
}
