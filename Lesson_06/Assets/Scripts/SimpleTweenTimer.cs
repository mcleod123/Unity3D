using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTweenTimer : ITimer
{
    public float Current { get; private set; }

    public float Normilized =>  Current/ _baseTime;

    public event Action OnTimerCompletedEvent;
    public event Action<float> OnTimerUpdateEvent;

    private float _baseTime;

    private Tweener _tweener;

    public SimpleTweenTimer(float time)
    {
        Current = 0f;
        _baseTime = time;
    }

    public void Reset()
    {
        
    }

    public void Start()
    {
        Current = 0f;
        _tweener = DOTween.To(() => Current, x => Current = x, _baseTime, _baseTime);
        _tweener.OnComplete(OnTimerEnd);
        _tweener.OnUpdate(OnTimerUpdate);
        _tweener.SetEase(Ease.Linear);
    }

    public void Stop()
    {
        _tweener.Kill();
    }

    private void OnTimerEnd()
    {
        OnTimerCompletedEvent?.Invoke();
    }

    private void OnTimerUpdate()
    {
        OnTimerUpdateEvent?.Invoke(Current);
    }
}
