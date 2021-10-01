using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ITimer
{
    float Current { get; }
    float Normilized { get; }

    event Action OnTimerCompletedEvent;
    event Action<float> OnTimerUpdateEvent;

    void Start();
    void Stop();
    void Reset();
}
