using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTrigger : MonoBehaviour
{
    public Animator animator;

    public void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey(KeyCode.F))
        {
            animator.Play("AnimButtonPressed");
        }
    }
}
