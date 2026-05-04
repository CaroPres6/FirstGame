using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damageValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player hit enemy!");
            ScoreManager.instance.RemoveScore(damageValue);
            // exemple simple : restart scène
            //UnityEngine.SceneManagement.SceneManager.LoadScene(
            //    UnityEngine.SceneManagement.SceneManager.GetActiveScene().name
            //);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(10);
                FindObjectOfType<LifeManager>().LoseLife();
            }
            else
            {
                Debug.LogWarning("PlayerHealth not found on Player!");
            }
        }
    }
}
