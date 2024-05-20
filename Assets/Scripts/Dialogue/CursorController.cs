using UnityEngine;

public class CursorController : MonoBehaviour
{
    void Start()
    {
        // Ensure the cursor is initially hidden
        HideCursor();
    }

    public void ShowCursor()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void HideCursor()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}

