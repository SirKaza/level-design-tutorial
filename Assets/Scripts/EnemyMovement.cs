using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public NavMeshAgent agent; // Reference to the enemy's NavMeshAgent
    public Transform player; // Reference to the player's transform
    public float chaseRange = 10f; // Range within which the enemy will chase the player

    void Update()
    {
        // Calculate the distance between the enemy and the player
        float distance = Vector3.Distance(transform.position, player.position);

        // If the player is within chase range, follow them
        if (distance <= chaseRange)
        {
            agent.SetDestination(player.position);
        }
    }
}