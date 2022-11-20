using MoreMountains.Feedbacks;
using UnityEngine;

public class SquishSquashBall : Juiceable
{
    #region Serialized Fields
    [SerializeField] MMF_Player _players;
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
        if (_gameManager._settings.Options.BallSquishEnabled)
        {
            MMFeedbacksPlay.Play(_feedbacks);
            _players.Initialization();
            _players.PlayFeedbacks();

        }
    }
    #endregion
}
