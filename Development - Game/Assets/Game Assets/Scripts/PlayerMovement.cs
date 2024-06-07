using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.VersionControl.Asset;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float movementSpeed = 8f;
    public float rotationSpeed = 240f;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;

        animator = GetComponent<Animator>();
    }

    // FixedUpdate is called once per fixed frame-rate frame.
    void FixedUpdate()
    {
        float movementInput = Input.GetAxis("Vertical");
        float rotationInput = Input.GetAxis("Horizontal");

        Vector3 movement = transform.forward * movementInput * movementSpeed * Time.deltaTime;
        transform.position += movement;

        Quaternion rotation = Quaternion.Euler(0f, rotationInput * rotationSpeed * Time.deltaTime, 0f);
        transform.rotation *= rotation;

        // Check if the player is moving forward, backward, or standing still.
        bool isMoving = movementInput != 0 || rotationInput != 0; // Any non-zero input means the player is moving
        bool isBackwards = movementInput < 0;

        // Update the animator with movement and backward states.
        animator.SetBool("IsBackwards", isBackwards);
        animator.SetBool("IsMoving", isMoving && !isBackwards);
    }
}
