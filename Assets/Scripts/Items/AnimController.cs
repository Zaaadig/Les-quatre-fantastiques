using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        StartCoroutine(Anim());
    }

    private IEnumerator Anim()
    {
        animator.Play("IdleState");
        yield return new WaitForSeconds(30f);
        animator.Play("BacAnim");
        StartCoroutine(Anim());

    }
}
