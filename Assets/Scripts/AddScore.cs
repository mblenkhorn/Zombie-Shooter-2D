using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public delegate void SendScore(int theScore);
    public static event SendScore OnSendScore;

    public int score = 10;
    private bool scoreSent = false;
    public bool isCollected = false;

    public void Die()
    {
        if(OnSendScore != null)
        {
            if (!scoreSent)
            {
                scoreSent = true;
                OnSendScore(score);
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
        Destroy(gameObject);
        Die();
    }



}
