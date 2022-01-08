using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    private Rigidbody2D _ballRB;

    [SerializeField] float _moveThreshold = 0.5f;

    private void Start()
    {
        _ballRB = GameObject.FindGameObjectWithTag("Ball").GetComponent<Rigidbody2D>();
    }



    private void FixedUpdate()
    {
        if (CheckSign(transform.position.x, _ballRB.velocity.x))
        {
            if(_ballRB.position.y > transform.position.y)
            {
                _rigidbody2D.AddForce(_movementSpeed * Vector2.up);
            } 
            else if (_ballRB.position.y < transform.position.y)
            {
                _rigidbody2D.AddForce(_movementSpeed * Vector2.down);
            }
        }

        else
        {
            if (transform.position.y > 0)
            {
                _rigidbody2D.AddForce(_movementSpeed * Vector2.down);
            }
            else if (transform.position.y < 0)
            {
                _rigidbody2D.AddForce(_movementSpeed * Vector2.up);
            }
        }
    }

    private void MovePaddle(float y)
    {
        var dir = y - transform.position.y;

        print(Mathf.Sign(dir));

        if (dir < _moveThreshold && dir > -_moveThreshold)
        {
            _rigidbody2D.velocity = Vector2.zero;
            return;
        }
        _rigidbody2D.AddForce(Mathf.Sign(dir) * _movementSpeed * Consts.MULTIPLIER * Time.deltaTime * Vector2.up);
    }

    private bool CheckSign(float a, float b)
    {
        return Mathf.Sign(a) == Mathf.Sign(b);
    }
}
