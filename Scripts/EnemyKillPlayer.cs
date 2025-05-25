using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyKillPlayer : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Debug.Log("Gracz dotkniêty przez wroga – Game Over!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Restart sceny
        }
    }
}
