using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //serialized variables
    [SerializeField] private Rigidbody2D playerRb;
    [SerializeField] private float moveSpeed = 2;

    //variables
    Vector2 moveDirection;

    // Update is called once per frame
    void Update()
    {
        movementInput();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    void movementInput()
    {
        float horizontalInout = Input.GetAxisRaw("Horizontal");
        float verticalInout = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2 (horizontalInout, verticalInout).normalized;
    }

    void Movement()
    {
        float moveX = moveDirection.x * moveSpeed * Time.deltaTime;
        float moveY = moveDirection.y * moveSpeed * Time.deltaTime;

        playerRb.velocity = new Vector2(moveX, moveY);
    }
}
