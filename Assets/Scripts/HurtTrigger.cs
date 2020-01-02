using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtTrigger : MonoBehaviour
{

    public int damage; //damage applied to the Player 
    public float resetTime = 0.25f; //time applied to collider being enabled and disabled 

    private void OnTriggerEnter2D(Collider2D collision) //when an object is triggered 
    {
        collision.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver); //sends the takedamage message with the amount of damage which ignores errors if the method is not found
        GetComponent<Collider2D>().enabled = false; //disables the collider2D component 
        Invoke("ResetTrigger", resetTime); //invokes the resetTrigger to allow the collider to be used again


        if (GetComponent<AudioSource>() != null) //checks for an audio source
        {
            GetComponent<AudioSource>().Play(); //if audio source is present, sound will play
        }
    }

    private void ResetTrigger() //function to reset the collider 
    {
        GetComponent<Collider2D>().enabled = true; //this will reset the collider
    }







}
