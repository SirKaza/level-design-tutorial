using UnityEngine;

public class CanvasElementToggle : MonoBehaviour
{
    [SerializeField] private GameObject uiElement;
    [SerializeField] private GameObject targetObject;
    private bool playerInZone = false;

    void Start()
    {
        if (uiElement != null)
            uiElement.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInZone = true;
            if (uiElement != null)
                uiElement.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInZone = false;
            if (uiElement != null)
                uiElement.SetActive(false);
        }
    }

    void Update()
    {
        if (playerInZone && Input.GetKeyDown(KeyCode.E))
        {
            if (uiElement != null)
                uiElement.SetActive(false);
            if (targetObject != null)
                Destroy(targetObject);
            Destroy(gameObject);
        }
    }
}
