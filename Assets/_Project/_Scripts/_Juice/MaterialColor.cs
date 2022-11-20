using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class MaterialColor : MonoBehaviour
{
    [SerializeField] private Color _color = Color.white;

    private Color _default;

    [SerializeField] private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        if(!_spriteRenderer) _spriteRenderer = GetComponent<SpriteRenderer>();
        _default = _spriteRenderer.color;
    }

    public void SwapColor()
    {
        _spriteRenderer.color = _spriteRenderer.color == _color ? _default : _color;
    }
}
