using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigerAscenseur : MonoBehaviour
{
    public GameObject ascenseur;

    private void OnTriggerEnter(Collider other)
    {
        ascenseur.GetComponent<Animator>().Play("AnimAscenseur");
    }

    //IEnumerator closeDoor()
    //{
    //    yield return new WaitForSeconds(1);
    //    ascenseur.GetComponent<Animator>().Play("AnimAscenseur");

    //}
}
