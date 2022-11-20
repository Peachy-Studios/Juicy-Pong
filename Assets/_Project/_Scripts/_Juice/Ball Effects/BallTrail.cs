using UnityEngine;

public class BallTrail : Juiceable
{
    #region Serialized Fields
    [SerializeField]
    private TrailRenderer _trailRenderer;
    #endregion

    #region Private Properties
    #endregion

    #region Public Properties
    #endregion

    #region MonoBehaviour Callbacks
    private void Update()
    {
        if( _trailRenderer && _trailRenderer.enabled != _gameManager._settings.Options.BallTrailEnabled )
        {
            Toggle();
        }
    }
    #endregion

    #region Private Methods
    #endregion

    #region Public Methods
    public override void Toggle()
    {
        _trailRenderer.enabled = _gameManager._settings.Options.BallTrailEnabled;
    }
    #endregion
}
