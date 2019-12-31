using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float moveSpeed = 100.0f; //how the fast the bullet will move
    public int damage = 1; //how much damage will it inflict 
    public float damageTime;



    private void OnEnable() //when it is enabled
    {
        GetComponent<Rigidbody2D>().AddForce(transform.up * moveSpeed); 
        Invoke("Die", damageTime); 
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver); //gets the transform component, the enemy will take damage, runs the TakeDamage method, sends a message to avoid errors 
        Die(); //calls the Die method
    }

    private void OnBecameInvisible() //when the object is no longer visible by the Camera 
    {
        Die(); //calls the die method
    }

    private void Die() 
    {
        gameObject.SetActive(false); //disables the object
    }

    private void OnDisable() //when it is disabled
    {
        CancelInvoke("Die"); //cancels the Die method
    }



}
