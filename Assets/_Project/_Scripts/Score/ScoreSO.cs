using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Score", menuName = "Score", order = 21)]
public class ScoreSO : ScriptableObject
{
    private int _score = 0;

    private void OnEnable()
    {
        _score = 0;
    }

    public void SetScore()
    {
        _score++;
    }

    public int GetScore()
    {
        return _score;
    }
}
