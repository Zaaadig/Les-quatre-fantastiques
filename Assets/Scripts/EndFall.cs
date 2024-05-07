using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFall : MonoBehaviour
{
    public GameObject poutre;

    private void OnTriggerEnter(Collider other)
    {
        poutre.GetComponent<Rigidbody>().useGravity = true;
        poutre.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None ;
    }
}
