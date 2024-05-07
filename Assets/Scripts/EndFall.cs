using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFall : MonoBehaviour
{
    public GameObject poutre;
    public GameObject poutre1;
    public GameObject platform;

    private void OnTriggerEnter(Collider other)
    {
        poutre.GetComponent<Rigidbody>().useGravity = true;
        poutre.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None ;
        poutre1.GetComponent<Rigidbody>().useGravity = true;
        poutre1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

        platform.GetComponent<Animator>().Play("AnimEnd");
    }
}
