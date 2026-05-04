using UnityEngine;
using TMPro;

public class LifeManager : MonoBehaviour
{
    public TextMeshProUGUI lifeText;
    int lives = 3;

    void Start()
    {
        UpdateUI();
    }

    public void LoseLife()
    {
        lives--;
        UpdateUI();

        if (lives <= 0)
        {
            Debug.Log("Game Over");
            // ici tu peux afficher menu game over
        }
    }

    void UpdateUI()
    {
        lifeText.text = lives.ToString();
    }
}