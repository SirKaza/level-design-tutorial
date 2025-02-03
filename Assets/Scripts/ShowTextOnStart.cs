using UnityEngine;

public class ShowTextOnStart : MonoBehaviour
{
    [SerializeField] GameObject textGameObject;
    [SerializeField] float initialDelay = 1.0f;
    [SerializeField] float displayDuration = 3.0f;

    void Start()
    {
        if (textGameObject != null)
        {
            Invoke("ShowText", initialDelay);
        }
        else
        {
            Debug.LogError("TextObject is not assigned!");
        }
    }

    void ShowText()
    {
        textGameObject.SetActive(true);
        Invoke("HideText", displayDuration);
    }

    void HideText()
    {
        if (textGameObject != null)
        {
            textGameObject.SetActive(false);
        }
    }
}
