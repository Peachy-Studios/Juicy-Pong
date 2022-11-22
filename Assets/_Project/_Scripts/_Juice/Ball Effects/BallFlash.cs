using System.Collections;
using UnityEngine;

public class BallFlash : Juiceable
{
    #region Serialized Fields
    [SerializeField]
    Gradient _spriteRendererFlickerColor;

    [SerializeField]
    TrailRenderer _trail;

    [SerializeField]
    float _flickerDuration;
    #endregion

    #region Private Properties
    Gradient _originalFlicker;
    #endregion

    #region Public Properties
    #endregion

    #region MonoBehaviour Callbacks
    private void Start()
    {
        if (_trail) _originalFlicker = _trail.colorGradient;
    }
    #endregion

    #region Private Methods
    #endregion

    #region Public Methods
    public override void Toggle()
    {
        if (_gameManager._settings.Options.BallFlashEnabled)
        {
            Play();

            if(_trail)
            {
                StartCoroutine(TrailFlicker());
            }

        }
    }

    IEnumerator TrailFlicker ()
    {
        _trail.colorGradient = _spriteRendererFlickerColor;
        yield return new WaitForSeconds(_flickerDuration);
        _trail.colorGradient = _originalFlicker;

    }

    #endregion
}
