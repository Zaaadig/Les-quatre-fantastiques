using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimLevier : MonoBehaviour
{
    public GameObject porte;
    public Animator animator;
    public bool playerIsClose = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            porte.GetComponent<Animator>().Play("AnimPorte2");
            animator.Play("AnimLevier");
            Debug.Log("Test1");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = false;
        }
    }
}
