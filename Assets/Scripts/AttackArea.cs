using UnityEngine;

public class AttackArea : MonoBehaviour
{

    private void OnTriggerStay(Collider collider)
    {
        if (collider.CompareTag("Destroy"))
        {
            collider.gameObject.SetActive(false);
        }
    }
}
