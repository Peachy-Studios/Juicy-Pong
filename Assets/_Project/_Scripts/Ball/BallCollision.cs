using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private GameManager _gameManager;
    [SerializeField] List<Juiceable> _feedbacks;

    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        foreach (IJuiceable feedback in _feedbacks)
        {
            feedback.Toggle();
        }

        // Rotate Ball
        RotateBall(collision.contacts[0].normal);
    }

    private void RotateBall(Vector3 normal)
    {
        if (!_gameManager._settings.Options.BallRotationEnabled) return;

        transform.rotation = Quaternion.FromToRotation(transform.position, normal);
    }
}
