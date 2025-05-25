using UnityEngine;

public class LeverTrigger : MonoBehaviour
{
    public GameObject floorToRemove; // Kawa³ek pod³ogi do usuniêcia
    private bool isPlayerInRange = false;
    private bool isActivated = false;

    void Update()
    {
        if (isPlayerInRange && !isActivated && Input.GetKeyDown(KeyCode.E))
        {
            isActivated = true;
            Debug.Log("DŸwignia u¿yta!");

            if (floorToRemove != null)
            {
                // Usuñ pod³ogê – mo¿na te¿ u¿yæ SetActive(false) zamiast Destroy
                Destroy(floorToRemove);
                // floorToRemove.SetActive(false); // alternatywnie
            }

            // Mo¿esz te¿ dodaæ animacjê dŸwigni tutaj
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }
}
