using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameEvents
{

    public static event System.Action GameStartEvent;

    public static event System.Action<int> ScorePointChangeEvent;


    public static void CallGameStartEvent()
    {
        
        GameStartEvent?.Invoke();
    }


    public static void CallScorePointChangeEvent(int scorePoint)
    {
        Debug.Log($"sdsdsds : {scorePoint}");
        ScorePointChangeEvent?.Invoke(scorePoint);

    }

}
