using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    

    public void StartGame()
    {
        SceneManager.LoadScene("Zombie Shooter Level 1"); //loads this scene
    }
    public void EndGame()
    {
        SceneManager.LoadScene("Game Over"); //loads this scene
    }
    
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Title Screen"); //loads this scene
    }

    public void ExitGame()
    {
        Application.Quit(); //exits application if the .exe is running
        Debug.Log("The game has stopping functioning");  //comment to notify if the player has exited the game 
    }

    







}
