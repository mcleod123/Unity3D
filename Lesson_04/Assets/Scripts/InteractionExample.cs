using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionExample : MonoBehaviour
{
    [SerializeField] private Button _closeButton;
    [SerializeField] private Toggle _togglePlay;
    [SerializeField] private Slider _slider;

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    private void Awake()
    {
        //_closeButton.onClick.AddListener(()=> gameObject.SetActive(false));

        _closeButton.onClick.AddListener(OnCloseButtonClickHandler);
        _togglePlay.onValueChanged.AddListener(OnTogglePlayChangedHandler);
        _slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCloseButtonClickHandler()
    {
        Debug.Log("OnCloseButtonClickHandler");
        Hide();
    }

    private void OnTogglePlayChangedHandler(bool isOn)
    {
        Debug.Log($"OnTogglePlayChangedHandler, isOn: {isOn}");
    }

    private void OnSliderValueChanged(float value)
    {
        Debug.Log($"OnTogglePlayChangedHandler, isOn: {value}");
    }
}