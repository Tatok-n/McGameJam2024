using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector2 moveInput;
    public float speed;

    private Vector3 playerVelocity;
    private bool grounded;
    public float gravity = -9.8f;
    public float jumpForce = 2f;

    public Camera cam;
    private Vector2 lookPos;
    private float xRotation = 0f;
    public float xSens = 30f;
    public float ySens = 30f;

    public void OnMove(InputAction.CallbackContext context){
        moveInput = context.ReadValue<Vector2>();
    }
    public void OnJump(InputAction.CallbackContext context){
        jump();
    }
    public void OnLook(InputAction.CallbackContext context){
        lookPos = context.ReadValue<Vector2>();
    }
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        grounded = controller.isGrounded;
        movePlayer();
        playerLook();
    }
    public void movePlayer(){
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = moveInput.x;
        moveDirection.z = moveInput.y;
        playerVelocity.y += gravity * Time.deltaTime;

        /*Testing grounds
        float ladderGrabDistance = 0.4f;
        if (Physics.Raycast(transform.position, moveDirection, out RaycastHit raycastHit, ladderGrabDistance))
        {
            Debug.Log(raycastHit.transform);
            if (raycastHit.transform.TryGetComponent(out Ladder ladder))
            {
                moveDirection.x = 0f;
                moveDirection.y = moveDirection.z;
                moveDirection.z = 0f;
                playerVelocity.y = 8f;
                grounded = true;
            }
        }
        */

        controller.Move(transform.TransformDirection(moveDirection)*speed*Time.deltaTime);

        //playerVelocity.y += gravity * Time.deltaTime;
        if (grounded && playerVelocity.y < 0){
            playerVelocity.y = -2f;
        }

        controller.Move(playerVelocity*Time.deltaTime);

        
    }
    public void jump(){
        if (grounded){
            playerVelocity.y = Mathf.Sqrt(jumpForce*-3f*gravity);
        }
    }
    public void playerLook(){
        xRotation -= (lookPos.y * Time.deltaTime)*ySens;
        xRotation = Mathf.Clamp(xRotation,-80f,80f);

        cam.transform.localRotation = Quaternion.Euler(xRotation,0,0);

        transform.Rotate(Vector3.up*(lookPos.x*Time.deltaTime)*xSens);
    }
}
