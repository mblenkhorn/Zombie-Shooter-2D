using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public delegate void UpdateHealth(int newHealth); //sends the current health to the player 
    public static event UpdateHealth OnUpdateHealth; //the event attached to the UpdateHealth delegate 


    private Animator gunAnim; //animator property for the animation 

    private void Start() //when it starts
    {
        gunAnim = GetComponent<Animator>(); //gets the animation component 
    }

    private void Update()
    {
        if (Input.GetMouseButton(0)) //if the mouse button has been pressed
        {
            gunAnim.SetBool("IsFiring", true); //play the animation 
        }
        else
        {
            gunAnim.SetBool("IsFiring", false); //don't play the animation 
        }
    }

    public void SendHealthData(int health) //function for sending health updates 
    {
        if(OnUpdateHealth != null) //if onupdate health is not equal to null 
        {
            OnUpdateHealth(health); //sends the message with the health value 
        }
    }
}
