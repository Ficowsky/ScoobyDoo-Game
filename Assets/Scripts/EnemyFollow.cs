using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform target;     // Gracz
    public float speed = 2.5f;   // Prêdkoœæ przeciwnika

    void Update()
    {
        if (target == null) return;

        Vector3 direction = (target.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over!");
            // Restart sceny lub przegrana
            UnityEngine.SceneManagement.SceneManager.LoadScene(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene().name
            );
        }
    }
}
