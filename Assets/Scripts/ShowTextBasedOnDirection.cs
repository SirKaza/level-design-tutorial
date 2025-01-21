using UnityEngine;
using System.Collections;

public class ShowTextBasedOnDirection : MonoBehaviour
{
    [SerializeField] GameObject textLeft;
    [SerializeField] GameObject textRight;
    [SerializeField] float displayDuration = 2.0f;

    void Start()
    {
        if (textLeft != null) textLeft.SetActive(false);
        if (textRight != null) textRight.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 direction = other.transform.position - transform.position;

            if (direction.z < 0)
            {
                ShowText(textLeft);
            }
            else
            {
                ShowText(textRight);
            }
        }
    }

    void ShowText(GameObject textObject)
    {
        if (textObject != null)
        {
            textObject.SetActive(true);
            StartCoroutine(HideTextAfterDelay(textObject, displayDuration));
        }
    }

    IEnumerator HideTextAfterDelay(GameObject textToHide, float delay)
    {
        yield return new WaitForSeconds(delay);
        textToHide.SetActive(false);
    }
}