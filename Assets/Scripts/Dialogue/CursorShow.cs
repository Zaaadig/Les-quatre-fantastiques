using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorShow : MonoBehaviour
{

    public CursorController controller;
    // Start is called before the first frame update
    void Update()
    {
        controller.ShowCursor();
    }

}
