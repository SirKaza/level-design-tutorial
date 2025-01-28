using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float detectionDistance = 2.0f;
    public float movementSpeed = 2.0f;
    public float targetHeight = -3f;

    private Vector3 initialPosition;

    private void Start()
    {
        initialPosition = transform.position;
    }

    private void Update()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player == null) return;

        float distance = Vector2.Distance(
            new Vector2(transform.position.x, transform.position.z),
            new Vector2(player.transform.position.x, player.transform.position.z)
        );

        Vector3 targetPosition = distance <= detectionDistance
            ? new Vector3(transform.position.x, targetHeight, transform.position.z)
            : initialPosition;

        transform.position = Vector3.MoveTowards(
            transform.position,
            targetPosition,
            movementSpeed * Time.deltaTime
        );
    }
}
