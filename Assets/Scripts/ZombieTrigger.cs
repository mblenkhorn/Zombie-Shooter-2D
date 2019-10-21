using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieTrigger : MonoBehaviour
{
    public GameObject player;
    public int health = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(health >=20){
            Debug.Log("You lost some health");
            health -= 20;
            Debug.Log("Your current health is " + health);
        }


        if(health == 0)
        {
            Debug.Log("YOU DIED, TRY AGAIN FROM THE START");
        }

        
    }




}
