using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimPorte : MonoBehaviour
{
    public GameObject porte;
    public bool playerIsClose = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            porte.GetComponent<Animator>().Play("AnimPorte");
            Debug.Log("Test");
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

