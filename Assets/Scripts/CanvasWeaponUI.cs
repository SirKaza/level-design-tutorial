using UnityEngine;

public class CanvasWeaponUI : MonoBehaviour
{
    [SerializeField] private GameObject uiElement;

    void Start()
    {
        if (uiElement != null)
            uiElement.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Transform[] allChildren = other.GetComponentsInChildren<Transform>();
            foreach (Transform child in allChildren)
            {
                if (child.CompareTag("Weapon"))
                {
                    if (uiElement != null)
                        uiElement.SetActive(true);
                    break;
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && uiElement != null)
            uiElement.SetActive(false);
    }
}
