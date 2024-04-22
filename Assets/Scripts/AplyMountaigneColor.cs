using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AplyMountaigneColor : MonoBehaviour
{
    [SerializeField] mountaigneColor data;
    // Start is called before the first frame update
    void Start()
    {
        Shader.SetGlobalColor("_main_color", data.firstColor);
        Shader.SetGlobalColor("_Second_Color", data.secondColor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
