using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public event Action OnScore;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.TryGetComponent(out Ball ball)) return;

        OnScore?.Invoke();
        ball.PlayWinParticle();
        ball.ResetBall();
    }
}
