using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PauseMenuDisplay : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;

    private void ShowHidePauseMenu()
    {
        _pauseMenu.SetActive(!_pauseMenu.activeSelf);
    }

    private void Start()
    {
        _pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame) ShowHidePauseMenu();
    }
}
