using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; //lets the components to talk to each other 

[System.Serializable]
public class OnDamagedEvent : UnityEvent<int> { }


public class HealthSystem : MonoBehaviour
{

    public int health = 10; //health property 
    public UnityEvent onDie; //this is a Unity Event for when the component is destroyed 
    public OnDamagedEvent onDamaged; //this is a Unity event for when the component is damaged 

    public void TakeDamage (int damage) //handles the Zombie's health when the Zombie is damaged 
    {
        health -= damage; //subtracts health by the amount of damage
        onDamaged.Invoke(health); //invokes the onDamaged event 



        if(health < 1) //if health is less than 1
        {
            onDie.Invoke(); //invokes the onDie event 
        } 
    }




}
