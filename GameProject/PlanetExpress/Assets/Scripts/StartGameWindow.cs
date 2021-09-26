using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class StartGameWindow : MonoBehaviour
{

    [SerializeField] Button _startGameButton;

    public delegate void MethodContainer();
    public event MethodContainer onClick;


    private void OnEnable()
    {
        _startGameButton.onClick.AddListener(StartMyGame);
    }

    private void OnDisable()
    {
        _startGameButton.onClick.RemoveListener(StartMyGame);
    }


    private void StartMyGame()
    {
        Debug.Log("OnClick start game button");

        // game is start!
        GameEvents.CallGameStartEvent();

        // hide window menu
        this.gameObject.SetActive(false);

    }

}
