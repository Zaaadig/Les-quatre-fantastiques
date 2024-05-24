using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : MonoBehaviour
{
    public Animator animator;
    public bool playerIsClose = false;
    public GameObject animPorte;

    private void Update()
    {
        if (Input.GetKey(KeyCode.E) && playerIsClose)
        {
            animator.Play("AnimButtonPressed");
            animPorte.GetComponent<AnimPorte>().enabled = true;
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
        }
    }
}
