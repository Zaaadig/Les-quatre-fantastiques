using UnityEngine;

public class GroundTeleportPlayer : MonoBehaviour
{
    public Transform teleportLocation; 
    public string playerTag = "Player"; 

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            collision.gameObject.transform.position = teleportLocation.position;
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }
}
