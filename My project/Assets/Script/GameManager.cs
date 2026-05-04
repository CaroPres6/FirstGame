using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject pausePanel;

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f; // stop le jeu
    }

    public void Restart()
    {
        Time.timeScale = 1f; // remet le jeu normal
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Pause()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0f; // stop le jeu
    }

    public void Resume()
    {
        Time.timeScale = 1f; // remet le jeu normal
        pausePanel.SetActive(false);
    }
}