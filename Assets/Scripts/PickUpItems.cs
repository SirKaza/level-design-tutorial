using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    private bool playerInRange = false;

    [SerializeField] private GameObject weapon;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
            if (weapon != null)
            {
                weapon.SetActive(true);
            }
        }
    }
}
