using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _paddlePrefab;
    [SerializeField] ScoreManager _leftWall, _rightWall;
    [SerializeField] ScoreDisplay _player1ScoreDisplay, _player2ScoreDisplay;
    [SerializeField] ScoreSO _player1Score, _player2Score;
    
    [SerializeField] public JuiceSO _settings;

    [SerializeField] List<Juiceable> _juiceables;

    [SerializeField] GameObject _ballPrefab, _eyes;
    private void Awake()
    {
        //Apply save items
        _settings.Options = (JuiceSettings) SerializationManager.Load(Application.persistentDataPath + "/saves/" + "Save" + ".save");

        //var player1 = PlayerInput.Instantiate(_paddlePrefab, controlScheme: InputScheme.Player1.ToString(), pairWithDevice: Keyboard.current);
        _rightWall.OnScore += _player1Score.SetScore;
        _rightWall.OnScore += _player1ScoreDisplay.SetText;
        
        //var player2 = PlayerInput.Instantiate(_paddlePrefab, controlScheme: InputScheme.Player2.ToString(), pairWithDevice: Keyboard.current);
        //player2.transform.position = new Vector3(9, 0, 0);
        
        _leftWall.OnScore += _player2Score.SetScore;
        _leftWall.OnScore += _player2ScoreDisplay.SetText;

        foreach (Juiceable juiceable in _juiceables)
        {
            _rightWall.OnScore += juiceable.Toggle;
            _leftWall.OnScore += juiceable.Toggle;
        }
    }

    private void Update()
    {
        if (!_settings.Options.EyeFollowEnabled)
        {
            if (_eyes.activeSelf) _eyes.SetActive(false);
            return;
        }

        else
        {
            if (!_eyes.activeSelf) _eyes.SetActive(true);
        }
    }

    private void OnApplicationQuit()
    {
        // Save Game
        SerializationManager.Save("Save", _settings.Options);
    }

    public void InstantiateBall()
    {
        Instantiate(_ballPrefab);
    }

    public void RestartLevel()
    {
        SceneHandler.ReloadScene();
    }
}

public enum InputScheme
{
    Player1,
    Player2,
    Computer
}