using UnityEngine;
using UnityEngine.InputSystem;
public class FPController : MonoBehaviour
{
[Header("Movement Settings")]
public float moveSpeed = 5f;
public float gravity = -9.81f;
[Header("Look Settings")]
public Transform cameraTransform;
public float lookSensitivity = 2f;
public float verticalLookLimit = 90f;
private CharacterController controller;
private Vector2 moveInput;
private Vector2 lookInput;
private Vector3 velocity;
private float verticalRotation = 0f;
private void Awake()
{
controller = GetComponent<CharacterController>();
Cursor.lockState = CursorLockMode.Locked;
Cursor.visible = false;
}
private void Update()
{
HandleMovement();
HandleLook();
}
public void OnMove(InputAction.CallbackContext context)
{
moveInput = context.ReadValue<Vector2>();
}
public void OnLook(InputAction.CallbackContext context)
{
lookInput = context.ReadValue<Vector2>();
}
public void HandleMovement()
{
Vector3 move = transform.right * moveInput.x + transform.forward *
moveInput.y;
controller.Move(move * moveSpeed * Time.deltaTime);
if (controller.isGrounded && velocity.y < 0)
velocity.y = -2f;
velocity.y += gravity * Time.deltaTime; //adds gravity to player's vertical velocity
controller.Move(velocity * Time.deltaTime); //moves player vertically using velocity value
}
public void HandleLook() //handles player camera and body rotation
{
float mouseX = lookInput.x * lookSensitivity; //calculate horizontal movement using look input and selected sensitivity
float mouseY = lookInput.y * lookSensitivity;
verticalRotation -= mouseY;
verticalRotation = Mathf.Clamp(verticalRotation, -
verticalLookLimit, verticalLookLimit);
cameraTransform.localRotation = Quaternion.Euler(verticalRotation,
0f, 0f);
transform.Rotate(Vector3.up * mouseX);
}
}