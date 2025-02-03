using UnityEngine;

public class ZoneCollider : MonoBehaviour
{
    public PlatformsMovement zoneMover;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            zoneMover.SetPlayerInside(true);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            zoneMover.SetPlayerInside(false);
    }
}
