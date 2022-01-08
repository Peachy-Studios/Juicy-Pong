using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPaddle : Paddle
{
    private float direction;
    private void OnMove(InputValue value)
    {
        direction = value.Get<float>();
    }

    private void FixedUpdate()
    {
        _rigidbody2D.AddForce(direction * _movementSpeed * Vector2.up);
    }
}
