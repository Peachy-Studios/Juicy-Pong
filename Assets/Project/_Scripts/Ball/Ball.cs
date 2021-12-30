using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private const float SPEED_MULTIPLIER = 1000f;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetBall();
    }

    private void InitialForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);

        var direction = new Vector2(x, y);
        AddForce(_speed * SPEED_MULTIPLIER * Time.deltaTime * direction);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody.AddForce(force);
    }

    public void ResetBall()
    {
        transform.position = Vector2.zero;
        _rigidbody.velocity = Vector2.zero;

        InitialForce();
    }
}
