using UnityEngine;

public class WinSoundEffect : Juiceable
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
    public override void Toggle()
    {
        if (_gameManager._settings.WinSoundEnabled) Play();
    }
    #endregion
}