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

    #endregion

    #region Private Properties
    #endregion

    #region Public Properties
    #endregion

    #region MonoBehaviour Callbacks
    private void Update()
    {
        Vector3 targetPos = _followObjectTransform.position;

        Vector2 dir = targetPos - _eyeBallRight.position;

        _eyeBallRight.transform.up = -dir;
        _eyeBallLeft.transform.up = -dir;

        Debug.Log(dir);
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
