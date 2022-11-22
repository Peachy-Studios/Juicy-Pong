using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Paddle : MonoBehaviour
{
    protected const float FORCE_MULTIPLIER = 1000;

    [SerializeField] protected float _movementSpeed;

    [SerializeField] protected Transform _paddleInitialTransform;

    protected Rigidbody2D _rigidbody2D;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void ResetPaddle()
    {
        transform.position = _paddleInitialTransform.position;
    }

    public void SetPaddleSpeed (float value)
    {
        _movementSpeed = value;
    }
    
}

