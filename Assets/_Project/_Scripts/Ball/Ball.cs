using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    #region Serialzefields
    [Header("Ball Settings")]
    [Tooltip("Ball Speed")]
    [SerializeField] 
    private float _speed = 1f;
    
    [Tooltip("Speed Multiplier")]
    [SerializeField] 
    private const float SPEED_MULTIPLIER = 100f;

    [Header("Juice Settings")]
    [Tooltip("Refences JuiceSO Scriptable Object")]
    [SerializeField] 
    JuiceSO _settings;
    #endregion

    #region Private Properties
    private Rigidbody2D _rigidbody;
    #endregion

    #region Unity Callbacks
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        if (_settings.SpawnEffectEnabled) Invoke("ResetBall", 1f);
        
        else ResetBall();
    }
    #endregion

    #region Private Methods
    private void InitialForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);

        var direction = new Vector2(x, y);
        AddForce(_speed * SPEED_MULTIPLIER * direction);
    }

    private IEnumerator DelayBallCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        ResetBall();
    }

    #endregion

    #region Public Methods
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
    #endregion
}