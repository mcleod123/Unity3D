using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenTimer : MonoBehaviour
{
    [SerializeField] private float _time;

    private float _timeCounter;

    private Tweener _timerTween;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    [ContextMenu("Start Timer")]
    private void StartTimer()
    {
        _timeCounter = 0;
        _timerTween = DOTween.To(() => _timeCounter, x => _timeCounter = x, _time, _time);
        _timerTween.OnComplete(OnTimerEnd);
        _timerTween.OnUpdate(OnTimerUpdate);
    }

    private void OnTimerEnd()
    {
        Debug.Log("OnTimerEnd");
    }

    private void OnTimerUpdate()
    {
        Debug.Log($"OnTimerUpdate: {_timeCounter}");
    }
}
