using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndFall : MonoBehaviour
{
    public GameObject poutre;
    public GameObject poutre1;
    public GameObject poutre2;
    public GameObject poutre3;
    public GameObject poutre4;
    public GameObject poutre5;
    public GameObject poutre6;
    public GameObject poutre7;
    public GameObject poutre8;
    public GameObject poutre9;
    public GameObject platform;

    private void OnTriggerEnter(Collider other)
    {
        poutre.GetComponent<Rigidbody>().useGravity = true;
        poutre.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None ;
        poutre1.GetComponent<Rigidbody>().useGravity = true;
        poutre1.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

        platform.GetComponent<Animator>().Play("AnimEnd");

        StartCoroutine(Suite());
    }

    IEnumerator Suite()
    {
        yield return new WaitForSeconds(1);
        poutre2.GetComponent<Rigidbody>().useGravity = true;
        poutre2.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        yield return new WaitForSeconds(1);
        poutre3.GetComponent<Rigidbody>().useGravity = true;
        poutre3.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        yield return new WaitForSeconds(1);
        poutre4.GetComponent<Rigidbody>().useGravity = true;
        poutre4.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        yield return new WaitForSeconds(1);
        poutre5.GetComponent<Rigidbody>().useGravity = true;
        poutre5.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        yield return new WaitForSeconds(1);
        poutre6.GetComponent<Rigidbody>().useGravity = true;
        poutre6.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        yield return new WaitForSeconds(1);
        poutre7.GetComponent<Rigidbody>().useGravity = true;
        poutre7.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        yield return new WaitForSeconds(1);
        poutre8.GetComponent<Rigidbody>().useGravity = true;
        poutre8.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        yield return new WaitForSeconds(1);
        poutre9.GetComponent<Rigidbody>().useGravity = true;
        poutre9.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

    }
}
