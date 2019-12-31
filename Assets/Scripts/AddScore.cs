using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public delegate void SendScore(int theScore); //sends the score stored in the score property
    public static event SendScore OnSendScore; //this is the event attached to the SendScore delegate 

    public int score = 10; //this is the Score property
    private bool scoreSent = false; //checks to see if the score is sent 

    public void Die() //when the Zombie is killed
    {
        if(OnSendScore != null) //checks to see if it is not equal to null 
        {
            if (!scoreSent) //checks to see if scoreSent hasn't occurred 
            {
                scoreSent = true; //scoreSent is now true
                OnSendScore(score); //sends the score property 
            }
            
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.CompareTag("Player"))
        {
            CollectCoin();

       }
   }

    public void CollectCoin()
    {
        Destroy(GameObject.FindWithTag("Coin"));
        Die();
    }



}
