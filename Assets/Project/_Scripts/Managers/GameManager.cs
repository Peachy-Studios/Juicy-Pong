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

    private void Start()
    {
        //var player1 = PlayerInput.Instantiate(_paddlePrefab, controlScheme: InputScheme.Player1.ToString(), pairWithDevice: Keyboard.current);
        _rightWall.OnScore += _player1Score.SetScore;
        _rightWall.OnScore += _player1ScoreDisplay.SetText;

        //var player2 = PlayerInput.Instantiate(_paddlePrefab, controlScheme: InputScheme.Player2.ToString(), pairWithDevice: Keyboard.current);
        //player2.transform.position = new Vector3(9, 0, 0);
        _leftWall.OnScore += _player2Score.SetScore;
        _leftWall.OnScore += _player2ScoreDisplay.SetText;
    }

    private void Setup(PlayerInput player)
    {

    }
}



public enum InputScheme
{
    Player1,
    Player2,
    Computer
}