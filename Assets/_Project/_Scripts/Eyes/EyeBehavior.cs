using UnityEngine;

public class EyeBehavior : Juiceable
{
	#region Serialized Fields
	[SerializeField]
	Transform _followObjectTransform;

    [SerializeField]
    Transform _eyeBallLeft;
    [SerializeField]
    Transform _eyeBallRight;

    [SerializeField]
    GameObject _smileObject, _scaredObject;
    #endregion

    #region Private Properties
    #endregion

    #region Public Properties
    #endregion

    #region MonoBehaviour Callbacks
    private void Update()
    {
        if(!_gameManager._settings.Options.EyeFollowEnabled)
        {
            if (gameObject.activeSelf) gameObject.SetActive(false);
            return;
        }

        else
        {
            if (!gameObject.activeSelf) gameObject.SetActive(true);
        }

        Vector3 targetPos = _followObjectTransform.position;

        Vector2 dir = targetPos - _eyeBallRight.position;

        _eyeBallRight.transform.up = -dir;
        _eyeBallLeft.transform.up = -dir;

        _smileObject.SetActive(_followObjectTransform.position.x < 0);
        _scaredObject.SetActive(_followObjectTransform.position.x >= 0);
    }

    #endregion

    #region Private Methods
    #endregion

    #region Public Methods
    public override void Toggle()
    {
        //if(_followObjectTransform.gameObject.activeSelf != _gameManager._settings.Options) 
    }
    #endregion
}
