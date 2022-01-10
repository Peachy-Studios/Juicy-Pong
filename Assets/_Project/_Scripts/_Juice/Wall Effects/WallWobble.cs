using UnityEngine;

public class WallWobble : Juiceable
{
    #region Serialized Fields
    #endregion

    #region Private Properties
    #endregion

    #region Public Properties
    #endregion

    #region MonoBehaviour Callbacks
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball")) Toggle();
    }
    #endregion

    #region Private Methods
    #endregion

    #region Public Methods

    public override void Toggle()
    {
        if (_gameManager._settings.WallWobbleEnabled) Play();
    }

    #endregion
}
