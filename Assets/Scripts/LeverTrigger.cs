using UnityEngine;

public class LeverTrigger : MonoBehaviour
{
    public GameObject floorToRemove; // Kawa�ek pod�ogi do usuni�cia
    private bool isPlayerInRange = false;
    private bool isActivated = false;

    void Update()
    {
        if (isPlayerInRange && !isActivated && Input.GetKeyDown(KeyCode.E))
        {
            isActivated = true;
            Debug.Log("D�wignia u�yta!");

            if (floorToRemove != null)
            {
                // Usu� pod�og� � mo�na te� u�y� SetActive(false) zamiast Destroy
                Destroy(floorToRemove);
                // floorToRemove.SetActive(false); // alternatywnie
            }

            // Mo�esz te� doda� animacj� d�wigni tutaj
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
