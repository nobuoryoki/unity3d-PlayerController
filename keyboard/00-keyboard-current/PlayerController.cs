using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        if (Keyboard.current != null)
        {
            if (Keyboard.current.aKey.isPressed)
            {
                Debug.Log("a");
            }

            if (Keyboard.current.dKey.isPressed)
            {
                Debug.Log("d");
            }
        }
    }
}
