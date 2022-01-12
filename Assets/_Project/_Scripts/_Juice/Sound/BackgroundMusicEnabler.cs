using UnityEngine;

public class BackgroundMusicEnabler : Juiceable
{
	#region Serialized Fields
	[SerializeField]
	AudioSource _audio;

    #endregion

    #region Private Properties
    #endregion

    #region Public Properties
    #endregion

    #region MonoBehaviour Callbacks
    private void Update()
    {
        Toggle();
    }
    #endregion

    #region Private Methods
    #endregion

    #region Public Methods
    public override void Toggle()
    {
        if (_gameManager._settings.BackgroundMusicEnabled && !_audio.isPlaying) _audio.Play();
        else if (!_gameManager._settings.BackgroundMusicEnabled && _audio.isPlaying) _audio.Stop();
    }
    #endregion
}
