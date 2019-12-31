using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    
    public GameObject titleScreen;
    public GameObject ControlsScreen;
    public GameObject AboutScreen;

    public bool isControls = false;
    public bool isAboutScreen = false;



    // Start is called before the first frame update
    void Start()
    {
        ControlsScreen = transform.GetChild(1).gameObject;
        AboutScreen = transform.GetChild(2).gameObject;
        
    }

    public void GameControls()
    {
        titleScreen.SetActive(false);
        ControlsScreen.SetActive(true);
        isControls = true;
        
    }

    public void AboutPage()
    {
        titleScreen.SetActive(false);
        AboutScreen.SetActive(true);
        isAboutScreen = true;

    }

    

    public void BackToScreen()
    {

        if(isControls == true)
        {
            isControls = false;
            ControlsScreen.SetActive(false);
            titleScreen.SetActive(true);
        }

        if(isAboutScreen == true)
        {
            isAboutScreen = false;
            AboutScreen.SetActive(false);
            titleScreen.SetActive(true);
        }
    }

    
}
