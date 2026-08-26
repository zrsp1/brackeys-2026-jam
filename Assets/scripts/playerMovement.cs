using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{

    public float moveSpeed;
    [SerializeField] private Rigidbody2D rb;
    private Vector2 moveInput;

    private void Start()
    {
        
    }

    private void Update()
    {
        rb.linearVelocity = moveInput * moveSpeed;

    }

    public void Move(InputAction.CallbackContext context)
    {
        //Debug.Log("moving");
        moveInput = context.ReadValue<Vector2>();
        
    }

}
