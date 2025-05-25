using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndTrigger : MonoBehaviour
{
    public GameObject winCanvas;
    public Button restartButton;

    private int enemiesPassed = 0;

    private void Start()
    {
        if (winCanvas != null)
            winCanvas.SetActive(false);

        if (restartButton != null)
            restartButton.onClick.AddListener(RestartGame);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Co� wesz�o w trigger: " + other.name);

        if (other.CompareTag("Enemy"))
        {
            enemiesPassed++;
            Debug.Log("Wesz�o " + enemiesPassed + " wrog�w.");

            if (enemiesPassed >= 3)
            {
                ShowWinScreen();
            }
        }
    }

    private void ShowWinScreen()
    {
        Debug.Log("POKAZUJ� WIN CANVAS");
        if (winCanvas != null)
            winCanvas.SetActive(true);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
