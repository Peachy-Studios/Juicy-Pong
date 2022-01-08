using MoreMountains.Feedbacks;
using System.Collections.Generic;
using UnityEngine;

public abstract class Juiceable : MonoBehaviour, IJuiceable
{
    protected GameManager _gameManager;

    [SerializeField] protected List<MMFeedbacks> _feedbacks;

    private void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }
    public abstract void Toggle();
}
