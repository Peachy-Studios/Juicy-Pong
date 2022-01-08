using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchColors : MonoBehaviour
{
    private MaterialColor[] _sprites;

    public void ToggleColors()
    {
        if (_sprites is null) _sprites = FindObjectsOfType<MaterialColor>();

        if (_sprites.Length <= 0) return;

        foreach (MaterialColor sprite in _sprites)
        {
            sprite.SwapColor();
        }
    }
}
