using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class RoadDecal : MonoBehaviour
{
    [SerializeField] DecalProjector decalProjector;

    private WaitForSeconds _wait = new WaitForSeconds(0.1f);

    void Start()
    {
        StartCoroutine(ToggleElement());
    }

    IEnumerator ToggleElement()
    {
        decalProjector.enabled = false;

        yield return _wait;

        decalProjector.enabled = true;
    }
}
