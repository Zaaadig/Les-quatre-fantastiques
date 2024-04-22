using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="colorManager")]
public class mountaigneColor : ScriptableObject
{
    [SerializeField]public Color firstColor;
    [SerializeField]public Color secondColor;
    // Start is called before the first frame update
    void Start()
    {
        Shader.SetGlobalColor("_main_color", firstColor);
        Shader.SetGlobalColor("_Second_Color", secondColor);
    }

    private void OnValidate()
    {
        Shader.SetGlobalColor("_main_color", firstColor);
        Shader.SetGlobalColor("_Second_Color", secondColor);
    }
    // Update is called once per frame

}
