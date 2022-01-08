using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    [SerializeField] float _bounceStrength;

    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (!collision.gameObject.TryGetComponent(out Ball ball)) return;

        var normal = collision.GetContact(0).normal;

        ball.AddForce(_bounceStrength * -normal);
    }
}
