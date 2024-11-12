using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public GameObject player;
    private readonly float turnSpeed = 150f;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
        speed = 1f;
    }

    void FixedUpdate()
    {
        HandleMovement();
    }

    void Update()
    {
        HandleSpeedUp();
    }

    private void HandleMovement()
    {
        float verticalInput = Input.GetAxis("Vertical");

        // Move the car forward or backward
        transform.Translate(speed * Time.deltaTime * verticalInput * Vector3.forward);

        HandleRotation();
    }

    private void HandleSpeedUp()
    {
        if (Input.GetKey(KeyCode.LeftShift) && speed < 10)
        {
            speed += 0.05f;
        }
        else if (speed > 1)
        {
            speed -= 0.01f;
        }
    }

    private void HandleRotation()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // A/D keys or arrow keys for turning

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.down, horizontalInput * turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
        }
    }
}
