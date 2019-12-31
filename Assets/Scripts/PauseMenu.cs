using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu; //this is the pause menu panel
    public bool isPaused = false;  //checks to see if the game is paused


    // Start is called before the first frame update
    void Start()
    {
        pauseMenu = transform.GetChild(0).gameObject; //gets the pause menu panel. 
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //if the spacebar is pressed
        {
            GamePaused(); //run this function 
        }
    }


    public void GamePaused()
    {
        pauseMenu.SetActive(true); //brings up the pause menu
        Time.timeScale = 0; //the game goes into paused mode
        isPaused = true; //game is paused
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false); //removes the pause menu
        Time.timeScale = 1; //the game goes back into play mode
        isPaused = false; //game is not paused

    }

    public void BackToTitleScreen()
    {
        Time.timeScale = 1; //game goes back into play mode
        SceneManager.LoadScene("Title Screen"); //loads the title screen
    }

    public void QuitGame()
    {
        Application.Quit(); //quits the game 
        Debug.Log("Game has stopped working");
    }
    
}
