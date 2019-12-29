using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    
    public GameObject titleScreen;
    public GameObject ControlsScreen;
    public GameObject HowToPlayScreen;
    public GameObject QuitPrompt;

    public bool isControls = false;
    public bool isHowToPlay = false;



    // Start is called before the first frame update
    void Start()
    {
        ControlsScreen = transform.GetChild(1).gameObject;
        HowToPlayScreen = transform.GetChild(2).gameObject;
        QuitPrompt = transform.GetChild(3).gameObject;
        
    }

    public void GameControls()
    {
        titleScreen.SetActive(false);
        ControlsScreen.SetActive(true);
        isControls = true;
        
    }

    public void HowToPlay()
    {
        titleScreen.SetActive(false);
        HowToPlayScreen.SetActive(true);
        isHowToPlay = true;

    }

    public void ExitGamePrompt()
    {
        QuitPrompt.SetActive(true);

    }

    public void BackToScreen()
    {
        QuitPrompt.SetActive(false);

        if(isControls == true)
        {
            isControls = false;
            ControlsScreen.SetActive(false);
            titleScreen.SetActive(true);
        }

        if(isHowToPlay == true)
        {
            isHowToPlay = false;
            HowToPlayScreen.SetActive(false);
            titleScreen.SetActive(true);
        }
    }

    
}
