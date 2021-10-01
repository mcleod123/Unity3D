using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class TimerCreator
{
    public static ITimer CreateTimer(float time)
    {
        return new SimpleTweenTimer(time);
    }
}
