using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int CurrentScore { get; private set; }
    public int HighScore { get; private set; }

    public void Start()
    {
        HighScore = SaveSystem.LoadHighScore();
    }


    public void AddScore(int amount)
    {
        CurrentScore += amount;
        
        if (CurrentScore > HighScore)
        {
            HighScore = CurrentScore;
            SaveSystem.SaveHighScore(HighScore);
        }
    }
    
    public void ResetScore()
    {
        CurrentScore = 0;
    }

    public void ResetHighScore()
    {
        HighScore = 0;
        SaveSystem.DeleteHighScore();
    }
    
}
