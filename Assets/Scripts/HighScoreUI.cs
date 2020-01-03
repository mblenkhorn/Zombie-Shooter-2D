using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct HighScores
{
    public List<int> scores;
}

public class HighScoreUI : MonoBehaviour
{
    public Text highScoreText; //this is the text objet for the highscore
    public HighScores highScore; //the is the highscore component
    private int totalHighScores = 5; //amount of highscores

    // Start is called before the first frame update
    void Start()
    {
        int score = PlayerPrefs.GetInt("Score"); //get the score number
        string s = PlayerPrefs.GetString("HighScores"); //gets the highscore 

        //print((score));

        if (string.IsNullOrEmpty(s)) //if the string is empty
        {
            print("list empty"); //print this string
            highScore = new HighScores(); //creates a new high score
            highScore.scores = new List<int>(); //creates a high score list 
        }
        else
        {
            highScore = JsonUtility.FromJson<HighScores>(s); //creates a Json file to store the highscore 
            
        }

        if(highScore.scores.Count < totalHighScores) //if the highscore count is less than the total high score
        {
            int amount = totalHighScores - highScore.scores.Count; //stores the amount of highscores
            for (int i = 0; i < amount; i++) //loops through the amounts
            {
                highScore.scores.Add(0); //adds a new high score 

            }
        }

        if(score > highScore.scores[totalHighScores - 1]) //if score is less than the highscore array
        {
            highScore.scores[totalHighScores - 1] = score; //removes the last score 
        }

        highScore.scores.Sort(); //sorts the the highscores
        highScore.scores.Reverse(0, totalHighScores); //reverses the highscores 

        //highScoreText.text = ";

        for(int i = 0; i < totalHighScores; i++) //loop through all the highscores 
        {
            if(highScore.scores[i] == score) //if the highscore array equals the score
            {
                highScoreText.text += "<color=#FF0000FF>" + (i + 1).ToString() + ". " + highScore.scores[i].ToString() + "</color>\n"; //displays the coloured highscore text 
            }
            else
            {
                highScoreText.text += (i + 1).ToString() + ". " + highScore.scores[i].ToString() + "\n"; //converts the score into string 
            }
        }

        string scoresJSON = JsonUtility.ToJson(highScore); //creates a new JSON file
        PlayerPrefs.SetString("HighScores", scoresJSON); //sets the high score sring 
        


    }

    
}
