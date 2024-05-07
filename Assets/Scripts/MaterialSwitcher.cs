using UnityEngine;
using System.Collections;


public class MaterialSwitcher : MonoBehaviour
{
    public Material material1;
    public Material material2;
    public float switchInterval = 1.0f;
    private Renderer rend;
    private bool isMaterial1 = true;

    void Start()
    {
        rend = GetComponent<Renderer>();
        if (rend == null)
        {
            Debug.LogError("Renderer component not found!");
            enabled = false;
            return;
        }

        StartCoroutine(SwitchMaterialCoroutine());
    }

    IEnumerator SwitchMaterialCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(switchInterval);

            if (isMaterial1)
            {
                rend.material = material2;
                isMaterial1 = false;
            }
            else
            {
                rend.material = material1;
                isMaterial1 = true;
            }
        }
    }
}
