using UnityEngine;
using UnityEngine.InputSystem;

public class Burung : MonoBehaviour
{
    [SerializeField] private float jumpForce = 5f;
    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame || Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            rig.linearVelocity = Vector2.zero;
            rig.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
