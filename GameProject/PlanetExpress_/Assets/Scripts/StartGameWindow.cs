using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class StartGameWindow : MonoBehaviour
{

    [SerializeField] Button _startGameButton;

    /*
    private static UnityAction _onStartGameEvent;

    public static event Action OnSessionOnEvent
    {
        add { _onStartGameEvent.Add(value); }
        remove { _onStartGameEvent.Remove(value); }
    }
    */

    public delegate void MethodContainer();
    public event MethodContainer onClick;


    private void OnEnable()
    {
        _startGameButton.onClick.AddListener(StartGame);
    }

    private void OnDisable()
    {
        _startGameButton.onClick.RemoveListener(StartGame);
    }


    private void StartGame()
    {
        Debug.Log("OnClick start game button");

        // hide window menu
        this.gameObject.SetActive(false);

    }

}
