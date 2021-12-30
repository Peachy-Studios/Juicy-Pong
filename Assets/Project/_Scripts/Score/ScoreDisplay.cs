using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private ScoreSO _score;

    public void SetText()
    {
        _scoreText.text = _score.GetScore().ToString();
    }
}
