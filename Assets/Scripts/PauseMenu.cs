using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused = false; 


    // Start is called before the first frame update
    void Start()
    {
        pauseMenu = transform.GetChild(0).gameObject;
        
    }


    public void GamePaused()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

    }

    public void BackToTitleScreen()
    {
        SceneManager.LoadScene("Title Screen");
    }
    
}
