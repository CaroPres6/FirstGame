using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;
    public int score = 0;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateScore();
    }

    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
        UpdateScore();
    }

    public void RemoveScore(int value)
    {
        if (score > 0){
            score -= value;
        }
        if (score == 0) {
            FindObjectOfType<GameManager>().GameOver(); ;
        }
        UpdateScore();

        Debug.Log("Score: " + score);
    }

    void UpdateScore()
    {
        scoreText.text = "Score : " + score;
    }
}