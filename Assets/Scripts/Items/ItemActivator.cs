using UnityEngine;

public class ItemActivator : MonoBehaviour
{
    public GameObject objectToActivate; // The GameObject to activate
    public GameObject objectToDeactivate; // The GameObject to deactivate

    // This function is called when another collider enters the trigger collider attached to this GameObject
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Activate the object to activate
            if (objectToActivate != null)
            {
                objectToActivate.SetActive(true);
                Debug.Log("Activated: " + objectToActivate.name);
            }

            // Deactivate the object to deactivate
            if (objectToDeactivate != null)
            {
                objectToDeactivate.SetActive(false);
                Debug.Log("Deactivated: " + objectToDeactivate.name);
            }
        }
    }
}
