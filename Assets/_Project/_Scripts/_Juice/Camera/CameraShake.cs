using UnityEngine;

public class CameraShake : Juiceable
{
    #region Serialized Fields
    #endregion

    #region Private Properties
    #endregion

    #region Public Properties
    #endregion

    #region MonoBehaviour Callbacks
    #endregion

    #region Private Methods
    #endregion

    #region Public Methods
    #endregion
    public override void Toggle()
    {
        // TODO: tell aisha ki cado tne asT
        if (_gameManager._settings.CameraShakeEnabled) MMFeedbacksPlay.Play(_feedbacks);
    }
}
