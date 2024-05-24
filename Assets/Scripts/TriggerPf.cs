using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPf : MonoBehaviour
{
    public Animator animator;
    public bool playerIsClose = false;
    public GameObject trigger;
    void Update()
    {
        if (playerIsClose == true)
        {
            animator.Play("AnimBarriere");
            trigger.SetActive(false);
            Debug.Log("Test");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        playerIsClose = true;

    }

    private void OnTriggerExit(Collider other)
    {
        playerIsClose = false;
    }
}
