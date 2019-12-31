using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; //this will let the components to talk to each other 

public class TimerEvent : MonoBehaviour
{
    public float time = 1; //how long to complete in seconds
    public bool repeat = false; //checks to see if it will repeat or not 
    public UnityEvent onTimerComplete; //this is an event for the onTimerComplete 

    private void Start()
    {
        if (repeat) //if repeat is true
        {
            InvokeRepeating("OnTimerComplete", 0, time); //the timer will repeat forever
        }
        else //if repeat is false
        {
            Invoke("OnTimerComplete", time); //the timer runs once 
        }

    }


    private void OnTimerComplete()
    {
        onTimerComplete.Invoke(); //invoke method for the onTimerComplete Event 
    }



}
