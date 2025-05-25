using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float cameraSpeed = 5f;
    public Vector3 offset;


    void Update()
    {
        Vector3 targetPosition = player.position + offset;
        transform.position = Vector3.Lerp(player.position, targetPosition, 5f * Time.deltaTime);

    }
}
