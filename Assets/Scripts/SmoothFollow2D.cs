using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollow2D : MonoBehaviour
{

    public Transform target; //needs a target for the camera to follow 
    public float smoothing = 0.5f; //controls the smoothness of the camera 

    // Start is called before the first frame update
     void FixedUpdate()
    {
        Vector3 newPos = new Vector3(target.position.x, target.position.y, transform.position.z); //creates a new position variable using the x and y of the target z of the camera's transform 
        transform.position = Vector3.Lerp(transform.position, newPos, (smoothing *0.001f)); //assigns the position of the camera using a Lerp animation 
    }
}
