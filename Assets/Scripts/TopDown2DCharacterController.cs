using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDown2DCharacterController : MonoBehaviour
{

    public float speed = 0.5f; //how fast the player moves 
    new Rigidbody2D rigidbody2D; //this will move our player 


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>(); //gets the rigidbody component on the Hero object
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal"); //gets keyboard input along x-axis
        float y = Input.GetAxis("Vertical"); //gets keyboard input along y-axis

        rigidbody2D.velocity = new Vector2(x, y) * speed; //sets player velocity and multiplies it by the speed 
        rigidbody2D.angularVelocity = 0.0f; //stops the player from spinning randomly if collided with an object 
        
    }
}
