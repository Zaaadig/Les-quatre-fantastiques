using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conitnuer : MonoBehaviour
{
    public NPC npcHolder;
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            npcHolder.NextLine();
        }
    }
}
