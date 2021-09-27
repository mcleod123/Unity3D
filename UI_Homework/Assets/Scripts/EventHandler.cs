using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class EventHandler : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IDragHandler
{

    // buttons
    [SerializeField] private Button _credisButton;
    [SerializeField] private Button _cinematicButton;

    // dropdowns
    private Dropdown _resolutionDropdown;
    private Dropdown _qualityDropdown;

    // Sliders
    [SerializeField] private Slider _musicVolumeSlider;
    [SerializeField] private Slider _masterVolumeSlider;


    // toggles
    [SerializeField] private Toggle _fullscreenToggle;
    [SerializeField] private Toggle _enableChallengeToggle;
    [SerializeField] private Toggle _friendsSpectacleToggle;
    [SerializeField] private Toggle _soundsInBacgroundToggle;


    void Start()
    {
        // buttons
        _credisButton.onClick.AddListener(CreditsButtonOnClick);
        _cinematicButton.onClick.AddListener(CinematicButtonOnClick);


        // sliders
        _musicVolumeSlider.onValueChanged.AddListener(OnMusicVolumeChanged);
        _masterVolumeSlider.onValueChanged.AddListener(OnMasterVolumeChanged);


        // dropdowns
        // НЕ РАБОТАЕТ И НЕ ПОЙМУ ПОЧЕМУ - не получается найти выпадающин списки как гейм обьекты
        // также не получилось представить их как SerializeField - не выбираются
        // _resolutionDropdown = GameObject.Find("ResolutionDropdown").GetComponent<Dropdown>();
        // _qualityDropdown = GameObject.Find("QualityDropdown").GetComponent<Dropdown>();

        //Debug.Log(GameObject.Find("ResolutionDropdown").ToString());
        // Debug.Log(_resolutionDropdown.ToString());

        /*
        _resolutionDropdown.onValueChanged.AddListener(delegate {
            ResolutionDropdownOnValueChanged(_resolutionDropdown);
        });
        _qualityDropdown.onValueChanged.AddListener(delegate {
            QualityDropdownOnValueChanged(_qualityDropdown);
        });
        */


        // toggles
        _fullscreenToggle.onValueChanged.AddListener(OnFullscreenToggleHandler);
        _enableChallengeToggle.onValueChanged.AddListener(OnEnableChallengeToggleHandler);
        _friendsSpectacleToggle.onValueChanged.AddListener(OnFriendsSpectacleToggleHandler);
        _soundsInBacgroundToggle.onValueChanged.AddListener(OnSoundsInBacgroundToggleHandler);


    }




    // Element UI Events

    // toggles
    private void OnFullscreenToggleHandler(bool isOn)
    {
        Debug.Log($"OnFullscreenToggleHandler, isOn: {isOn}");
    }

    private void OnEnableChallengeToggleHandler(bool isOn)
    {
        Debug.Log($"OnEnableChallengeToggleHandler, isOn: {isOn}");
    }

    private void OnFriendsSpectacleToggleHandler(bool isOn)
    {
        Debug.Log($"OnFriendsSpectacleToggleHandler, isOn: {isOn}");
    }

    private void OnSoundsInBacgroundToggleHandler(bool isOn)
    {
        Debug.Log($"OnSoundsInBacgroundToggleHandler, isOn: {isOn}");
    }




    // sliders
    private void OnMasterVolumeChanged(float value)
    {
        Debug.Log($"MasterVolumeHandler, isOn: {value}");
    }    
    private void OnMusicVolumeChanged(float value)
    {
        Debug.Log($"MusicVolumeHandler, isOn: {value}");
    }



    // resolution dropdown
    private void ResolutionDropdownOnValueChanged(Dropdown resolutionDropdownValue)
    {
        Debug.Log($"(⊙_◎) Resolution Dropdown Change! New Value: {resolutionDropdownValue.value.ToString()}");
    }

    // Quality dropdown
    private void QualityDropdownOnValueChanged(Dropdown qualityDropdownValue)
    {
        Debug.Log($"(⊙_◎) Quality Dropdown Change! New Value: {qualityDropdownValue.value.ToString()}");
    }



    // credits button
    private void CreditsButtonOnClick()
    {
        Debug.Log("( ͡° ͜ʖ ͡°)  Credits button click!");
    }

    // cinematic button
    private void CinematicButtonOnClick()
    {
        Debug.Log("( ͡° ͜ʖ ͡°) Credits button click!");
    }








    // Canvas Events
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -1)
        {
            Debug.Log("Left Mouse Canvas Click");
        }
        else if (eventData.pointerId == -2)
        {
            Debug.Log("Right Mouse Canvas Click");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pointer Canvas Enter..");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Pointer Canvas Exit..");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Pointer Canvas Down..");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragged On Canvas..");
    }



}
