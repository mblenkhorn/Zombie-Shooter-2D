using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    //public GameManager gameManager;
    public GameObject titleScreen;
    public GameObject ControlsScreen;
    public GameObject HowToPlayScreen;

    public bool isControls = false;
    public bool isHowToPlay = false;



    // Start is called before the first frame update
    void Start()
    {
        ControlsScreen = transform.GetChild(1).gameObject;
        HowToPlayScreen = transform.GetChild(2).gameObject;
        
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

    
}
