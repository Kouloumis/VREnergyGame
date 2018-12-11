using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMovement : MonoBehaviour {

	public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

	public float sensitivity = 2f;

	public Transform eyes;

	float rotX;
	float rotY;

    void Start()
    {
        controller = GetComponent<CharacterController>();

        // let the gameObject fall down
        gameObject.transform.position = new Vector3(0, 5, 0);

		Cursor.lockState = CursorLockMode.Locked;

		eyes = this.gameObject.transform.GetChild(0);
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection = moveDirection * speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

		rotX = Input.GetAxis("Mouse X") * sensitivity;
		rotY = Input.GetAxis("Mouse Y") * sensitivity;

		transform.Rotate(0, rotX, 0);
		eyes.Rotate(-rotY, 0, 0);

        // Apply gravity
        moveDirection.y = moveDirection.y - (gravity * Time.deltaTime);

        // Move the controller
        controller.Move(moveDirection * Time.deltaTime);
    }
}