using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5.0f;
    Rigidbody rb;

    Vector3 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveDirection = Vector3.zero;

        if (Keyboard.current != null)
        {
            if (Keyboard.current.aKey.isPressed)
                moveDirection.x -= 1;

            if (Keyboard.current.dKey.isPressed)
                moveDirection.x += 1;

            if (Keyboard.current.wKey.isPressed)
                moveDirection.z += 1;

            if (Keyboard.current.sKey.isPressed)
                moveDirection.z -= 1;
        }

        moveDirection = moveDirection.normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(
            moveDirection.x * moveSpeed,
            rb.linearVelocity.y,
            moveDirection.z * moveSpeed
        );
    }
}