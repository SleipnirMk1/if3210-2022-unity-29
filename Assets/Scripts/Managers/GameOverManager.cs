using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public Text warningText;
    public Text finalScoreText;
    public PlayerHealth playerHealth;
    public ScoreManager scoreManager;
 
    Animator anim;
 
    void Awake()
    {
        anim = GetComponent<Animator>();
    }
 
    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            scoreManager.isScoring = false;
            finalScoreText.text = "FINAL SCORE: " + Mathf.RoundToInt(scoreManager.score).ToString();
            anim.SetTrigger("GameOver");
        }
    }
 
    public void ShowWarning(float enemyDistance)
    {
        warningText.text = string.Format("! {0} m",Mathf.RoundToInt(enemyDistance));
        anim.SetTrigger("Warning");
    }
}