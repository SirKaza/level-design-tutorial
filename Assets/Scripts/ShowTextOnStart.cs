using UnityEngine;

public class ShowTextOnStart : MonoBehaviour
{
    [SerializeField] GameObject textGameObject;
    [SerializeField] float displayDuration = 3.0f;

    void Start()
    {
        if (textGameObject != null)
        {
            textGameObject.SetActive(true);
            Invoke("HideText", displayDuration); 
        }
        else
        {
            Debug.LogError("TextObject is not assigned!");
        }
    }

    void HideText()
    {
        if (textGameObject != null)
        {
            textGameObject.SetActive(false);
        }
    }
}
