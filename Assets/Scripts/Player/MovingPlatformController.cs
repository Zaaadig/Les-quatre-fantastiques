using UnityEngine;

public class MovingPlatformController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Parent the player to the moving platform
            other.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Unparent the player from the moving platform
            other.transform.parent = null;
        }
    }
}
