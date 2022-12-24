// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 5.0f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        // Keyboard input
        if (Input.GetKey(KeyCode.A))
        {
            horizontalMovement = -1.0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontalMovement = 1.0f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            verticalMovement = 1.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            verticalMovement = -1.0f;
        }

        Vector2 movement = new Vector2(horizontalMovement, verticalMovement);

        rb.velocity = movement * speed;
    }
}
