using UnityEngine;

public class PlatformsMovement : MonoBehaviour
{
    public float speed = 2f;
    public float hiddenOffset = 10f;
    private Vector3 originalPosition;
    private Vector3 hiddenPosition;
    private bool playerInside = false;

    void Start()
    {
        originalPosition = transform.position;
        hiddenPosition = new Vector3(originalPosition.x, originalPosition.y - hiddenOffset, originalPosition.z);
    }

    void Update()
    {
        Vector3 target = playerInside ? originalPosition : hiddenPosition;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

    public void SetPlayerInside(bool inside)
    {
        playerInside = inside;
    }
}
