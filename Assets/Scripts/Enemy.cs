using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; //lets the components to talk to each other 


[System.Serializable] //tells the editor that the event can be configured 

public class EnemySpawnedEvent : UnityEvent<Transform> { } //this is a class for EnemySpawnedEvent which has a transform parameter
public class Enemy : MonoBehaviour
{

    public EnemySpawnedEvent onSpawn; //custom Unity Event for spawning a Zombie 

    private void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player"); //gets the Player Gameobject with the Player Tag
        onSpawn.Invoke(player.transform); //invokes the onSpawn method and gives it the Player transform 
    }




}
