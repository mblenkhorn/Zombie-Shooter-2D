using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //allows usage of the UI classes 

public class GameUI : MonoBehaviour
{

    public Slider healthBar; //this is the healthbar slider
    public Text scoreText; //this is the text for the Score 

    public int playerScore = 0; //current score of the Player 

    private void OnEnable()
    {
        Player.OnUpdateHealth += UpdateHealthBar; //enables the healthbar function
        AddScore.OnSendScore += UpdateScore; //enables the score function
    }

    private void OnDisable()
    {
        Player.OnUpdateHealth -= UpdateHealthBar; //disables the healthbar function
        AddScore.OnSendScore -= UpdateScore; //disables the score function
        PlayerPrefs.SetInt("Score", playerScore); //sets the score for the High Score 
    }

    private void UpdateHealthBar(int health) //updates the slider amount according to the health amount 
    {
        healthBar.value = health; //sets the slider amount 
    }

    private void UpdateScore(int theScore)
    {
        playerScore += theScore; //adds the score amount 
        scoreText.text = "SCORE: " + playerScore.ToString(); //sends it the text to display it 
    }


}
