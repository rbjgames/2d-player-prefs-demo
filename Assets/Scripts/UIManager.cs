using UnityEngine;
using TMPro;


public class UIManager : MonoBehaviour
{
   [SerializeField] private GameManager gameManager;
   [SerializeField] private TextMeshProUGUI scoreText;
   [SerializeField] private TextMeshProUGUI highScoreText;


   private void Start()
   {
      UpdateUI();
   }
   
   private void UpdateUI()
   {
      scoreText.text = $"Score: {gameManager.CurrentScore}";
      highScoreText.text = $"High Score: {gameManager.HighScore}";
   }

   public void AddScore()
   {
      const int amount = 10;
      gameManager.AddScore(amount);
      UpdateUI();
   }

   public void ResetScore()
   {
      gameManager.ResetScore();
      UpdateUI();
   }

   public void ResetHighScore()
   {
      gameManager.ResetHighScore();
      UpdateUI();
   }
   
   
}
