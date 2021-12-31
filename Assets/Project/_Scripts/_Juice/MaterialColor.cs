using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class MaterialColor : MonoBehaviour
{
    [SerializeField] private Color _color = Color.white;

    private SpriteRenderer _spriteRenderer;

    private void OnEnable()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void SwapColor()
    {
        _spriteRenderer.color = _spriteRenderer.color == _color ? Color.white : _color;
    }
}
