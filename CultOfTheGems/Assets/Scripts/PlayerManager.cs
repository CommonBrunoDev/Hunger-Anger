using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class PlayerManager : MonoBehaviour
{
    private bool OnInteractClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            return true;
        }
        return false;   
    }

    private bool OnInteractHeld()
    {
        if (Input.GetMouseButton(0) && !Input.GetMouseButtonDown(0))
        {
            return true;
        }

        return false;
    }
}
