using UnityEngine;
using UnityEngine.UI; // lub TMPro je?li u?ywasz TextMeshPro

public class NoteInteraction : MonoBehaviour
{
    public GameObject player;
    public GameObject textUI; // pod??cz UI tekstu
    public string message = "To jest tre?? kartki.";
    private bool playerNearby = false;

    void Update()
    {
        if (playerNearby && Input.GetKeyDown(KeyCode.E))
        {
            textUI.SetActive(!textUI.activeSelf); // prze??cz widoczno?? tekstu
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            playerNearby = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            playerNearby = false;
            textUI.SetActive(false); // ukryj tekst, gdy wyjdziesz
        }
    }
}
