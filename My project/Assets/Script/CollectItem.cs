using UnityEngine;

public class CollectItem : MonoBehaviour
{
    public int scoreValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Item collected!");

            // augmenter score (exemple simple)
            ScoreManager.instance.AddScore(scoreValue);

            // détruire l'objet
            Destroy(gameObject);
        }
    }
}