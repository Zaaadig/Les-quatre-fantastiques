using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastTrigger : MonoBehaviour
{
    public Animator porte;

    private void OnTriggerEnter(Collider other)
    {
        porte.Play("AnimPorteFinale");
    }
}
