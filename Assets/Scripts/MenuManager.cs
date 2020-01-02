using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    
    public GameObject titleScreen; //object for the title screen
    public GameObject ControlsScreen; //object for the controls screen
    public GameObject AboutScreen; //object for the about screen

    public bool isControls = false; //checks to see if the controls screen is clicked
    public bool isAboutScreen = false; //checks to see if the about screen is clicked



    //Start is called before the first frame update
    void Start()
    {
       ControlsScreen = transform.GetChild(1).gameObject; //gets the controlscreen object
       AboutScreen = transform.GetChild(2).gameObject; //gets the aboutscreen object
        
    }

    public void GameControls()
    {
        if (GetComponent<AudioSource>() != null) //checks for an audiosource
        {
            GetComponent<AudioSource>().Play(); //plays the sound 
        }

        titleScreen.SetActive(false); //title screen goes away 
        ControlsScreen.SetActive(true); //brings up the controls screen
        isControls = true; //controls screen is brought up
        
    }

    public void AboutPage()
    {

        titleScreen.SetActive(false); //title screen goes away
        AboutScreen.SetActive(true); //brings up the about screen
        isAboutScreen = true; //about screen is brought up 


    }

    

    public void BackToScreen()
    {

        if(isControls == true) //if the controls screen is up
        {
            if (GetComponent<AudioSource>() != null) //checks for an audiosource
            {
                GetComponent<AudioSource>().Play(); //plays the sound 
            }

            isControls = false; //controls screen is disabled
            ControlsScreen.SetActive(false); //controls screen goes away
            titleScreen.SetActive(true); //title screen is brought up 
        }

        if(isAboutScreen == true) //if the controls screen is up
        {
            if (GetComponent<AudioSource>() != null) //checks for an audiosource
            {
                GetComponent<AudioSource>().Play(); //plays the sound 
            } 

            isAboutScreen = false; //About screen is disabled
            AboutScreen.SetActive(false); //About screen goes away
            titleScreen.SetActive(true); //title screen is brought up 
        }
    }

    
}
