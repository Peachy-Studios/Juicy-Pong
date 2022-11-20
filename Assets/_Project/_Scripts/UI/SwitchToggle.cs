using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections;

public class SwitchToggle : MonoBehaviour
{
    #region Serialize Fields
    [Header("UI Settings")]
    [SerializeField] RectTransform _uiHandleRectTransform;
    [SerializeField] Color _backgroundActiveColor;
    [SerializeField] Color _handleActiveColor;
    
    [Header("Parameters")]
    [SerializeField] JuiceSO _juiceSetting;
    [SerializeField] SettingsEnum _setting;
    [SerializeField] bool _shouldRestart;
    #endregion

    #region Private Fields
    Image _backgroundImage, _handleImage;

    Color _backgroundDefaultColor, _handleDefaultColor;

    Toggle _toggle;

    Vector2 _handlePosition;

    bool _hasStartCallbackEnded;
    #endregion

    #region MonoBehaviour Callbacks
    private void Start()
    {
        InitializeVariable();

        _hasStartCallbackEnded = true;

    }
    private void OnDestroy()
    {
        _toggle.onValueChanged.RemoveAllListeners();
    }
    #endregion

    #region Private Methods
    void InitializeVariable()
    {
        // Get Ccomponents
        _toggle = GetComponent<Toggle>();
        _backgroundImage = _uiHandleRectTransform.parent.GetComponent<Image>();
        _handleImage = _uiHandleRectTransform.GetComponent<Image>();

        // Sets default variables
        _handlePosition = _uiHandleRectTransform.anchoredPosition;
        _backgroundDefaultColor = _backgroundImage.color;
        _handleDefaultColor = _handleImage.color;

        // Adds event listener to toggle 
        _toggle.onValueChanged.AddListener(OnSwitch);

        // sets the toggle state
        _toggle.isOn = (bool)Utils.GetPropertyValue(_juiceSetting.Options, _setting.ToString());
        if (_toggle.isOn) OnSwitch(true);
    }

    void OnSwitch(bool on)
    {
        Utils.SetPropertyValue(_juiceSetting.Options, _setting.ToString(), on);
        _uiHandleRectTransform.DOAnchorPos(on ? _handlePosition * -1 : _handlePosition, .4f).SetEase(Ease.InOutBack);
        _backgroundImage.DOColor(on ? _backgroundActiveColor : _backgroundDefaultColor, .6f);
        _handleImage.DOColor(on ? _handleActiveColor : _handleDefaultColor, .4f);
        
        if (_hasStartCallbackEnded) SerializationManager.Save("Save", _juiceSetting.Options);

        if (_shouldRestart && _hasStartCallbackEnded) StartCoroutine(OnSwitchCoroutine());
    }
    #endregion

    #region Coroutines
    IEnumerator OnSwitchCoroutine()
    {
        while (DOTween.TotalPlayingTweens() > 0) yield return null;

        SceneHandler.ReloadScene();
    }
    #endregion
}
